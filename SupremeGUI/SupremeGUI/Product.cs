using System;
using System.Collections.Generic;
using System.Net;

using Helpers;
using Selector;

namespace SupremeGUI
{
    public class Product
    {

        private bool IsCorrectlyInitialized = false;

        private String[] _keywords;
        private Selector.Category _category;
        private CookieContainer _cookiereference;
        private bool _colorRelevant, _sizeRelevant;
        private String _color;
        private String _size;

        private String _articleID = null, _styleID = null, _sizeID = null, _referer = null;

        private Product innerProduct = null;

        public Product()
        {

        }

        public ref CookieContainer cookieReference()
        {
            return ref _cookiereference;
        }

        public String getArticleID()
        {
            return _articleID != null ? _articleID : throw (new ArticleNotInitializedException());
        }

        public String getStyleID()
        {
            return _styleID != null ? _styleID : throw (new ArticleNotInitializedException());
        }

        public String getSizeID()
        {
            return _sizeID != null ? _sizeID : throw (new ArticleNotInitializedException());
        }

        public String getReferer()
        {
            return _referer != null ? _referer : throw (new ArticleNotInitializedException());
        }

        public ref CookieContainer getCookieReference() {
            return ref _cookiereference;
        }

        public Product(Selector.Category category, String[] keywords, ref CookieContainer cookiereference, bool sizeRelevant = false, String size = "", bool colorRelevant = false, String color = "")
        {
            _cookiereference = cookiereference;
            _category = category;
            _keywords = keywords;
            _sizeRelevant = sizeRelevant;
            _size = size;
            _colorRelevant = colorRelevant;
            _color = color;
        }

        public Product getInnerProduct()
        {
            return innerProduct != null ? innerProduct : throw (new ArticleNotInitializedException());
        }

        public bool isCorrectlyInitialized()
        {
            return IsCorrectlyInitialized;
        }

        private void _initialize(String articleID, String styleID, String sizeID, String referer)
        {
            _articleID = articleID;
            _styleID = styleID;
            _sizeID = sizeID;
            _referer = referer;
        }

        public void initialize()
        {
            int keyLength = _keywords.Length;
            String tmpSize = "";

            List<String> shopList = SupremeRequest.getShopList();

            foreach (String s in shopList)
            {
 
                if (_category.Value != Category.All.Value && s.StartsWith(_category.Value) || _category.Value == Category.All.Value)
                {
                    SupremeRequest sr = new SupremeRequest(new Uri("http://www.supremenewyork.com/shop/" + s), ref _cookiereference);
                    String resString = sr.GET();

                    
                    int tempCtr = 0;

                    foreach (String k in _keywords)
                    {
                        if (resString.ToLower().Contains(k.ToLower()))
                        {
                            tempCtr++;
                        }
                    }

                    if (tempCtr == keyLength)
                    {
                        if (_colorRelevant)
                        {
                            if (ExHelper.IsRightColor(resString, _color))
                            {
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (ExHelper.IsSoldOut(resString) == null)
                        {
                            IsCorrectlyInitialized = false;
                            throw (new ArticleSoldOutException());
                        }
                        else
                        {
                            if (_sizeRelevant)
                            {
                                if (ExHelper.IsCorrectSize(resString, _size) != null)
                                {
                                    tmpSize = ExHelper.IsCorrectSize(resString, _size);
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                tmpSize = ExHelper.IsCorrectSize(resString, _size);
                            }

                            String tmpStyle = ExHelper.getStyleID(resString);
                            String tmpMatch = ExHelper.IsSoldOut(resString);

                            innerProduct = new Product();
                            innerProduct._initialize(tmpMatch, tmpStyle, tmpSize, ("http://supremenewyork.com/shop/" + s));
                            IsCorrectlyInitialized = true;
                        }
                    }
                    else
                    {
                        tempCtr = 0;
                        continue;
                    }
                }
                else
                {

                }
            }
        }
    }
}
