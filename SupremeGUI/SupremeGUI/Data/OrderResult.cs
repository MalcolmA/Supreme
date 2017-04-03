using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public struct OrderResult
    {
        public bool success;
        public BillingInformation billingInfo;
        public CreditcardDetails ccInfo;
        public String rawResult;
    }
}
