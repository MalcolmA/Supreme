using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using Helpers;

namespace SupremeGUI
{
    public class Supreme
    {
        public static OrderResult Order(Product product, BillingInformation billingInfo, CreditcardDetails ccInfo)
        {
            OrderResult oReturn = new OrderResult();

            if (addToCart(product))
            {
                String successPageSrc = checkOut(product, billingInfo, ccInfo);

                if (successPageSrc.Contains("successfully"))
                {
                    oReturn.success = true;
                    oReturn.ccInfo = ccInfo;
                    oReturn.billingInfo = billingInfo;
                    oReturn.rawResult = successPageSrc;
                }
                else
                {
                    oReturn.success = false;
                    oReturn.ccInfo = ccInfo;
                    oReturn.billingInfo = billingInfo;
                    oReturn.rawResult = successPageSrc;
                }
            } else
            {
                oReturn.success = false;
            }

            return oReturn;
        }

        private static bool addToCart(Product product)
        {
            
            SupremeRequest sr = new SupremeRequest(new Uri("http://www.supremenewyork.com/shop/" + product.getInnerProduct().getArticleID() + "/add"), ref product.getCookieReference());

            String postString = "utf8=" + Constants.UTF8 + "&style=" + product.getInnerProduct().getStyleID() + "&size=" + product.getInnerProduct().getSizeID() + "&commit=" + Constants.en_commit;

            String tmpRes = sr.POST(postString, true, false, true, product.getInnerProduct().getReferer());
            sr = new SupremeRequest(new Uri("http://www.supremenewyork.com/shop/cart"), ref product.getCookieReference());
            tmpRes = sr.GET();

            if (tmpRes.Contains("1 item"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static String checkOut(Product product, BillingInformation billingInfo, CreditcardDetails ccInfo)
        {
            SupremeRequest sr = new SupremeRequest(new Uri("https://www.supremenewyork.com/checkout"), ref product.getCookieReference());

            String checkOutPageSrc = sr.GET(true);

            String authenticity_token = ExHelper.getAuthenticity_token(checkOutPageSrc);
            String postString = SupremeRequest.generatePostString(authenticity_token, billingInfo, ccInfo);

            sr = new SupremeRequest(new Uri("https://www.supremenewyork.com/checkout"), ref product.getCookieReference());
            String successPageSrc = sr.POST(postString, true, true, true, "https://www.supremenewyork.com/checkout");

            return successPageSrc;
        }
    }
}
