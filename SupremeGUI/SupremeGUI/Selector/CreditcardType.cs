using System;
using System.Collections.Generic;
using System.Text;

namespace Selector
{
    public class CreditcardType
    {
        private CreditcardType(string value) { Value = value; }

        public string Value { get; set; }

        public static CreditcardType VISA { get { return new CreditcardType("visa"); } }
        public static CreditcardType MasterCard { get { return new CreditcardType("master"); } }
        public static CreditcardType American_Express { get { return new CreditcardType("american_express"); } }
    }
}
