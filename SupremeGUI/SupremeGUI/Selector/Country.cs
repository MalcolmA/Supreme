using System;
using System.Collections.Generic;
using System.Text;

namespace Selector
{
    public class Country
    {
        public Country(string value) { Value = value; }

        public string Value { get; set; }

        public static Country United_Kingdom { get { return new Country("UK"); } }
        public static Country Austria { get { return new Country("AT"); } }
        public static Country Belarus { get { return new Country("BY"); } }
        public static Country Belgium { get { return new Country("BE"); } }
        public static Country Bulgaria { get { return new Country("BG"); } }
        public static Country Croatia { get { return new Country("HR"); } }
        public static Country Czech_Republic { get { return new Country("CZ"); } }
        public static Country Denmark { get { return new Country("DK"); } }
        public static Country Estonia { get { return new Country("EE"); } }
        public static Country Finland { get { return new Country("FI"); } }
        public static Country France { get { return new Country("FR"); } }
        public static Country Germany { get { return new Country("DE"); } }
        public static Country Greece { get { return new Country("GR"); } }
        public static Country Hungary { get { return new Country("HU"); } }
        public static Country Iceland { get { return new Country("IS"); } }
        public static Country Ireland { get { return new Country("IE"); } }
        public static Country Italy { get { return new Country("IT"); } }
        public static Country Latvia { get { return new Country("LV"); } }
        public static Country Lithuania { get { return new Country("LT"); } }
        public static Country Luxembourg { get { return new Country("LU"); } }
        public static Country Monaco { get { return new Country("MC"); } }
        public static Country Netherlands { get { return new Country("NL"); } }
        public static Country Norway { get { return new Country("NO"); } }
        public static Country Poland { get { return new Country("PL"); } }
        public static Country Portugal { get { return new Country("PT"); } }
        public static Country Romania { get { return new Country("RO"); } }
        public static Country Russia { get { return new Country("RU"); } }
        public static Country Slovakia { get { return new Country("SK"); } }
        public static Country Slovenia { get { return new Country("SI"); } }
        public static Country Spain { get { return new Country("ES"); } }
        public static Country Sweden { get { return new Country("SE"); } }
        public static Country Switzerland { get { return new Country("CH"); } }
        public static Country Turkey { get { return new Country("TR"); } }
    }
}
