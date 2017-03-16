using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace Supreme
{
	public sealed class Categories
	{
		public static String All = "all", Jackets = "jackets", Shirts = "shirts", Tops_Sweaters = "topssweaters", Sweatshirts = "sweatshirts", Pants = "pants", Hats = "hats", Bags = "bags", Accessoires = "accessories", Skate = "skate";
	}

	public sealed class Creditcards
	{
		public static String VISA = "visa", MasterCard = "mastercard", AmericanExpress = "amex";
	}

	public struct cartInfo
	{
		public const String UTF8 = "%E2%9C%93";
		public const String en_commit = "add+to+basket";
		public String articleID;
		public String styleID;
		public String sizeID;
		public String referer;
		public bool success;
	}

	public struct billingInfo
	{
		public const String UTF8 = "%E2%9C%93";
		public const String en_commit = "process+payment";
		public String fullname;
		public String email;
		public String telephone;
		public String address_1;
		public String address_2;
		public String address_3;
		public String city;
		public String zip;
		public String countryCode;
		public String creditcard;
		public String ccNumber;
		public String ccMonth;
		public String ccYear;
		public String ccCVV;
	}

	class Program
	{
		private static WebClient legitClient = new WebClient();
		private static CookieContainer cookies = new CookieContainer();

		/// <summary>
		/// Searches for articles in Article-List (List<String> shopList).
		/// Searches for those articles by keywords, all keywords have to match for the article to be found.
		/// </summary>
		/// <param name="shopList">The List of encrypted Supreme-Article-URLs</param>
		/// <param name="category">The category of which to search in (use Categories.All in case of doubt)</param>
		/// <param name="keywords">They keywords the article have to match, all keywords have to match. 
		/// Include at least one keyword and separate each keyword by comma. (e.g. hanes,tagless,shirt)</param>
		/// <param name="colorRelevant">true if the color of the article is relevant, false if not. 
		/// Will pick the first available color if set to false.</param>
		/// <param name="color">The name of the color the Article has to match (e. g. Aqua or Royal). Will only apply
		/// if colorRelevant is set to true.</param>
		/// <param name="sizeRelevant">true if the article size is relevant, false if not.
		/// Will pick the first available size if set to false.</param>
		/// <param name="size">The name of the size the Article has to match (e. g. Medium or Large). Will only apply
		/// if sizeRelevant is set to true.</param>
		/// <returns>Returns structure (cartInfo) with ArticleID, SizeID and other relevant info to checkout the item. 
		/// Will return cartInfo.articleID = "article_sold_out" or "article_not_found" on error.</returns>
		private static cartInfo retrieveSpecificUrl(List<String> shopList, String category, String keywords, bool colorRelevant = false, String color = "undefined", bool sizeRelevant = false, String size = "undefined")
		{
			String[] innerKeywords = keywords.Split(',');
			int keyLength = innerKeywords.Length;
			String egalSize = "";

			foreach (String s in shopList)
			{
				if (category != Categories.All && s.StartsWith(category) || category == Categories.All)
				{
					HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://supremenewyork.com/shop/" + s);
					req.Method = "GET";
					req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:51.0) Gecko/20100101 Firefox/51.0";
					req.CookieContainer = cookies;

					HttpWebResponse res = (HttpWebResponse)req.GetResponse();
					StreamReader reader = new StreamReader(res.GetResponseStream());
					String resString = reader.ReadToEnd();
					reader.Close();

					int tempCtr = 0;

					foreach (String k in innerKeywords)
					{
						if (resString.ToLower().Contains(k.ToLower()))
						{
							tempCtr++;
						}
					}

					if (tempCtr == keyLength)
					{
						// All keywords contained
						// Now get /add/Cart URL
						if (colorRelevant)
						{
							if (new Regex("<p class=\"style\" itemprop=\"model\">" + color.ToLower() + "</p>").IsMatch(resString.ToLower()))
							{
								// Right color found
							}
							else
							{
								// Not the right color found
								continue;
							}
						}

						String addCartMatch = new Regex("<form class=\"add\" id=\"cart-addf\" action=\"/shop/(.+?)/add\"").Match(resString).Groups[1].Value;
						if (addCartMatch == "")
						{
							// Sold out
							cartInfo _falseInfo;
							_falseInfo.success = false;
							_falseInfo.articleID = "article_sold_out";
							_falseInfo.styleID = "";
							_falseInfo.sizeID = "";
							_falseInfo.referer = "";

							return _falseInfo;
						}
						else
						{
							// not sold out
							// now check for right size available
							if (sizeRelevant)
							{
								String rSize = new Regex("<option value=\"(.+?)\">" + size + "</option>").Match(resString).Groups[1].Value;

								if (rSize.Length > 0)
								{
									egalSize = rSize;
								}
								else
								{
									continue;
								}
							}
							else
							{
								egalSize = new Regex("<option value=\"(.+)\">(.+?)</option>").Match(resString).Groups[1].Value;
								if (egalSize == "")
								{
									egalSize = new Regex("<input type=\"hidden\" name=\"size\" id=\"size\" value=\"(.+?)\"").Match(resString).Groups[1].Value;
								}
							}

							// now retrieve other info needed for adding to cart
							String style = new Regex("<input type=\"hidden\" name=\"style\" id=\"style\" value=\"(.+?)\" />").Match(resString).Groups[1].Value;
							cartInfo innerInfo;
							innerInfo.articleID = addCartMatch;
							innerInfo.sizeID = egalSize;
							innerInfo.styleID = style;
							innerInfo.success = true;
							innerInfo.referer = "http://supremenewyork.com/shop/" + s;
							return innerInfo;
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

			cartInfo falseInfo;
			falseInfo.success = false;
			falseInfo.articleID = "article_not_found";
			falseInfo.styleID = "";
			falseInfo.sizeID = "";
			falseInfo.referer = "";

			return falseInfo;

		}

		/// <summary>
		/// Retrieves the Article-List (all articles)
		/// For performance (if needed) you can change /shop/all to /shop/new
		/// to only search in the new articles group.
		/// </summary>
		/// <returns>Returns the encrypted article URLs in a list.</returns>
		private static List<String> retrieveShopList()
		{
			List<String> innerList = new List<String>();
			String resString = legitClient.DownloadString("http://supremenewyork.com/shop/all");
			String pattern = "<a style=\"height:81px;\" href=\"/shop/(.+?)\">";
			Regex matchEx = new Regex(pattern);

			foreach (Match m in matchEx.Matches(resString))
			{
				innerList.Add(m.Groups[1].Value.ToString());
			}

			return innerList;
		}

		/// <summary>
		/// Adds the item to cart.
		/// </summary>
		/// <param name="info">Structure with information about the corresponding item</param>
		/// <returns>Returns true if adding to cart was successful, false if not. (maybe sold out)</returns>
		private static bool addToCart(cartInfo info)
		{
			String postString = "utf8=" + cartInfo.UTF8 + "&style=" + info.styleID + "&size=" + info.sizeID + "&commit=" + cartInfo.en_commit;
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://supremenewyork.com/shop/" + info.articleID + "/add");
			req.CookieContainer = cookies;
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded";
			req.ContentLength = postString.Length;
			req.AllowAutoRedirect = false;
			req.Referer = info.referer;
			req.Headers["Upgrade-Insecure-Requests"] = "1";
			req.Host = "www.supremenewyork.com";

			StreamWriter writePost = new StreamWriter(req.GetRequestStream());
			writePost.Write(postString);
			writePost.Close();

			HttpWebResponse res = (HttpWebResponse)req.GetResponse();

			StreamReader readResponse = new StreamReader(res.GetResponseStream());
			String finalResponse = readResponse.ReadToEnd();
			readResponse.Close();


			req = (HttpWebRequest)WebRequest.Create("http://supremenewyork.com/shop/cart");
			req.Method = "GET";
			req.AllowAutoRedirect = true;
			req.CookieContainer = cookies;

			readResponse = new StreamReader(req.GetResponse().GetResponseStream());
			finalResponse = readResponse.ReadToEnd();
			readResponse.Close();

			if (finalResponse.Contains("1 item"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Helperfunction to generate the final POST-Request to buy the item.
		/// </summary>
		/// <param name="info">Structure with information about the billing address</param>
		/// <param name="authenticity_token">XRSS-Token required by Supreme.</param>
		/// <returns></returns>
		private static String generatePostString(billingInfo info, String authenticity_token)
		{
			StringBuilder postString = new StringBuilder();
			postString.Append("utf8=");
			postString.Append(billingInfo.UTF8);
			postString.Append("&authenticity_token=");
			postString.Append(Uri.EscapeDataString(authenticity_token));
			postString.Append("&order%5Bbilling_name%5D=");
			postString.Append(info.fullname.Replace(" ", "+"));
			postString.Append("&order%5Bemail%5D=");
			postString.Append(info.email.Replace("@", "%40"));
			postString.Append("&order%5Btel%5D=");
			postString.Append(info.telephone.Replace("+", "%2B"));
			postString.Append("&order%5Bbilling_address%5D=");
			postString.Append(info.address_1.Replace(" ", "+"));
			postString.Append("&order%5Bbilling_address_2%5D=");
			postString.Append(info.address_2.Replace(" ", "+"));
			postString.Append("&order%5Bbilling_address_3%5D=");
			postString.Append(info.address_3.Replace(" ", "+"));
			postString.Append("&order%5Bbilling_city%5D=");
			postString.Append(info.city.Replace(" ", "+"));
			postString.Append("&order%5Bbilling_zip%5D=");
			postString.Append(info.zip);
			postString.Append("&order%5Bbilling_country%5D=");
			postString.Append(info.countryCode);
			postString.Append("&same_as_billing_address=1&store_credit_id=");
			postString.Append("&credit_card%5Btype%5D=");
			postString.Append(info.creditcard);
			postString.Append("&credit_card%5Bcnb%5D=");
			postString.Append(info.ccNumber);
			postString.Append("&credit_card%5Bmonth%5D=");
			postString.Append(info.ccMonth);
			postString.Append("&credit_card%5Byear%5D=");
			postString.Append(info.ccYear);
			postString.Append("&credit_card%5Bvval%5D=");
			postString.Append(info.ccCVV);
			postString.Append("&order%5Bterms%5D=0&order%5Bterms%5D=1&hpcvv=");
			postString.Append("&commit=");
			postString.Append(billingInfo.en_commit);

			return postString.ToString();
		}

		/// <summary>
		/// Checks the item finally out. Whole process is over after calling this function.
		/// </summary>
		/// <param name="info">Structure with information about the billing address</param>
		/// <returns>Returns true if order was successful, false if not. (maybe sold out)</returns>
		private static bool checkOut(billingInfo info)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.supremenewyork.com/checkout");
			req.Method = "GET";
			req.CookieContainer = cookies;

			HttpWebResponse res = (HttpWebResponse)req.GetResponse();
			StreamReader responseReader = new StreamReader(res.GetResponseStream());
			String finalRes = responseReader.ReadToEnd();
			responseReader.Close();

			String authenticity_token = new Regex("<input type=\"hidden\" name=\"authenticity_token\" value=\"(.+?)\" />").Match(finalRes).Groups[1].Value;
			String postString = generatePostString(info, authenticity_token);

			req = (HttpWebRequest)WebRequest.Create("https://www.supremenewyork.com/checkout");
			req.Referer = "https://www.supremenewyork.com/checkout";
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded";
			req.Headers["Upgrade-Insecure-Requests"] = "1";
			req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:51.0) Gecko/20100101 Firefox/51.0";
			req.ContentLength = postString.Length;
			req.Host = "www.supremenewyork.com";
			req.CookieContainer = cookies;

			StreamWriter postWriter = new StreamWriter(req.GetRequestStream());
			postWriter.Write(postString);
			postWriter.Close();

			res = (HttpWebResponse)req.GetResponse();
			responseReader = new StreamReader(res.GetResponseStream());
			finalRes = responseReader.ReadToEnd();
			responseReader.Close();

			if (finalRes.Contains("successfully"))
			{
				return true;
			}
			else
			{
				return false;
			}
			// utf8=%E2%9C%93&authenticity_token=QpL1suA%2BOUgD9QX5SOrGN4z64nv0NUvhGr1zU5DPSAITJVEZkKtXB3%2FLAA3SKorVCY218vrtqiqzJZeRUo%2Bfrw%3D%3D&order%5Bbilling_name%5D=f+name&order%5Bemail%5D=fmail%40x.de&order%5Btel%5D=%2B4971623682&order%5Bbilling_address%5D=adress+one&order%5Bbilling_address_2%5D=address+two+3&order%5Bbilling_address_3%5D=address+three&order%5Bbilling_city%5D=plaats&order%5Bbilling_zip%5D=PLZ&order%5Bbilling_country%5D=DE&same_as_billing_address=1&store_credit_id=&credit_card%5Btype%5D=visa&credit_card%5Bcnb%5D=123456789&credit_card%5Bmonth%5D=02&credit_card%5Byear%5D=2017&credit_card%5Bvval%5D=123&order%5Bterms%5D=0&order%5Bterms%5D=1&hpcvv=&commit=process+payment
		}

		private static void Main(string[] args)
		{
			// Please keep in mind that you must not use special characters (includes ä, ö, ü etc.)
			// Except " " in info.fullName, info.address_1, .._2, .._3, info.city
			// Except "@" in info.email 
			// Except "+" in info.telephone

			billingInfo info = new billingInfo();
			info.creditcard = Creditcards.VISA;
			info.fullname = "Max Mustermann";
			info.email = "max@muster.de";
			info.telephone = "+4915113371337";
			info.address_1 = "12 Muehlen Street";
			info.address_2 = "Bldg E";
			info.address_3 = "Floor 2 Apt 12";
			info.zip = "78467";
			info.city = "Konstanz";
			info.countryCode = "DE";
			info.ccNumber = "4906759104921149";
			info.ccMonth = "12";
			info.ccYear = "2019";
			info.ccCVV = "999";

			String keywords = "lacoste,track,jacket";
			String color = "black";
			String size = "Medium";


			List<String> urlList = retrieveShopList();
			cartInfo realInfo = retrieveSpecificUrl(urlList, Categories.All, keywords, true, color, true, size);

			if (realInfo.articleID != "article_sold_out" && realInfo.articleID != "article_not_found")
			{
				if (addToCart(realInfo))
				{
					// Added to Cart
					if (checkOut(info))
					{
						// Checked out successfully. Order placed.
					}
					else
					{
						// Error checking out
					}
				}
				else
				{
					// Error  adding to cart
				}
			}
		}
	}
}
