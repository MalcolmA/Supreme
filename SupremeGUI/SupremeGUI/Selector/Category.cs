using System;

namespace Selector
{
    public class Category
    {
        public Category(string value) { Value = value; }

        public string Value { get; set; }

        public static Category All { get { return new Category("all"); } } 
        public static Category New { get { return new Category("jackets"); } }
        public static Category Jackets { get { return new Category("shirts"); } }
        public static Category Shirts { get { return new Category("topssweaters"); } }
        public static Category Tops_Sweaters { get { return new Category("sweatshirts"); } }
        public static Category Sweatshirts { get { return new Category("pants"); } }
        public static Category Hats { get { return new Category("hats"); } }
        public static Category Bags { get { return new Category("bags"); } }
        public static Category Accessories { get { return new Category("accessories"); } }
        public static Category Skate { get { return new Category("skate"); } }
    }
}

