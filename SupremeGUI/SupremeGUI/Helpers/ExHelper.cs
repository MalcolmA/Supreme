using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Helpers
{
    public class ExHelper
    {
        public static String getAuthenticity_token(String content)
        {
            return new Regex("<input type=\"hidden\" name=\"authenticity_token\" value=\"(.+?)\" />").Match(content).Groups[1].Value;
        }

        public static String getStyleID(String content)
        {
            return new Regex("<input type=\"hidden\" name=\"style\" id=\"style\" value=\"(.+?)\" />").Match(content).Groups[1].Value;
        }

        public static bool IsRightColor(String content, String color)
        {
            return new Regex("<p class=\"style\" itemprop=\"model\">" + color.ToLower() + "</p>").IsMatch(content.ToLower());
        }

        public static String IsSoldOut(String content)
        {
            String inner = new Regex("<form class=\"add\" id=\"cart-addf\" action=\"/shop/(.+?)/add\"").Match(content).Groups[1].Value;
            return inner == "" ? null : inner;
        }

        public static String IsCorrectSize(String content, String size)
        {
            String tempErg = new Regex("<option value=\"(.+?)\">" + size.ToLower() + "</option>").Match(content.ToLower()).Groups[1].Value;
            String realErg = tempErg.Length > 0 ? tempErg : null;
            String tempErgHidden = new Regex("<input type=\"hidden\" name=\"size\" id=\"size\" value=\"(.+?)\"").Match(content.ToLower()).Groups[1].Value;
            String realErgHidden = tempErgHidden.Length > 0 ? tempErgHidden : null;
    
            return realErg != null ? realErg : realErgHidden;
        }
    }
}
