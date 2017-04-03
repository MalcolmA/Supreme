using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

using Data;

namespace Helpers
{
    public class SupremeRequest
    {
        private Uri _target;
        private String tempResponse;
        private CookieContainer _cookies;
        private StreamWriter reqWriter;
        private StreamReader reqReader;
        private HttpWebRequest req;
        
        public SupremeRequest(Uri target, ref CookieContainer cookies)
        {
            _target = target;
            _cookies = cookies;
        }

        public String POST(String content, bool upgradeInsecureRequests = false, bool sslTlsRequest = false, bool addReferer = false, String referer = "")
        {
            if(sslTlsRequest) { ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; }
            req = (HttpWebRequest)WebRequest.Create(_target);
            req.CookieContainer = _cookies;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:51.0) Gecko/20100101 Firefox/51.0";
            req.ContentLength = content.Length;
            if (addReferer) { req.Referer = referer; }
            if (upgradeInsecureRequests) { req.Headers["Upgrade-Insecure-Requests"] = "1"; }
            req.Host = "www.supremenewyork.com";

            reqWriter = new StreamWriter(req.GetRequestStream());
            reqWriter.Write(content);
            reqWriter.Close();

            reqReader = new StreamReader(req.GetResponse().GetResponseStream());
            tempResponse = reqReader.ReadToEnd();
            reqReader.Close();

            return tempResponse;
        }

        public String GET(bool sslTlsRequest = false)
        {
            if (sslTlsRequest) { ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; }

            req = (HttpWebRequest)WebRequest.Create(_target);
            req.Method = "GET";
            req.CookieContainer = _cookies;
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:51.0) Gecko/20100101 Firefox/51.0";
            reqReader = new StreamReader(req.GetResponse().GetResponseStream());
            tempResponse = reqReader.ReadToEnd();
            reqReader.Close();

            return tempResponse;
        }

        public static String generatePostString(String authenticity_token, BillingInformation billingInfo, CreditcardDetails ccInfo)
        {
            StringBuilder postString = new StringBuilder();
            postString.Append("utf8=");
            postString.Append(Constants.UTF8);
            postString.Append("&authenticity_token=");
            postString.Append(Uri.EscapeDataString(authenticity_token));
            postString.Append("&order%5Bbilling_name%5D=");
            postString.Append(billingInfo.FullName.Replace(" ", "+"));
            postString.Append("&order%5Bemail%5D=");
            postString.Append(billingInfo.Email.Replace("@", "%40"));
            postString.Append("&order%5Btel%5D=");
            postString.Append(billingInfo.Telephone.Replace("+", "%2B"));
            postString.Append("&order%5Bbilling_address%5D=");
            postString.Append(billingInfo.Address_1.Replace(" ", "+"));
            postString.Append("&order%5Bbilling_address_2%5D=");
            postString.Append(billingInfo.Address_2.Replace(" ", "+"));
            postString.Append("&order%5Bbilling_address_3%5D=");
            postString.Append(billingInfo.Address_3.Replace(" ", "+"));
            postString.Append("&order%5Bbilling_city%5D=");
            postString.Append(billingInfo.City.Replace(" ", "+"));
            postString.Append("&order%5Bbilling_zip%5D=");
            postString.Append(billingInfo.ZipCode);
            postString.Append("&order%5Bbilling_country%5D=");
            postString.Append(billingInfo.Country.Value);
            postString.Append("&same_as_billing_address=1&store_credit_id=");
            postString.Append("&credit_card%5Btype%5D=");
            postString.Append(ccInfo.Type.Value);
            postString.Append("&credit_card%5Bcnb%5D=");
            postString.Append(ccInfo.Number);
            postString.Append("&credit_card%5Bmonth%5D=");
            postString.Append(ccInfo.Month);
            postString.Append("&credit_card%5Byear%5D=");
            postString.Append(ccInfo.Year);
            postString.Append("&credit_card%5Bvval%5D=");
            postString.Append(ccInfo.CVV2);
            postString.Append("&order%5Bterms%5D=0&order%5Bterms%5D=1&hpcvv=");
            postString.Append("&commit=");
            postString.Append(Constants.en_commit);

            return postString.ToString();
        }

        public static List<String> getShopList()
        {
            List<String> innerList = new List<String>();
            String resString = new WebClient().DownloadString("http://supremenewyork.com/shop/all");
            String pattern = "<a style=\"height:81px;\" href=\"/shop/(.+?)\">";
            Regex matchEx = new Regex(pattern);

            foreach (Match m in matchEx.Matches(resString))
            {
                innerList.Add(m.Groups[1].Value.ToString());
            }

            return innerList;
        }
    }
}
