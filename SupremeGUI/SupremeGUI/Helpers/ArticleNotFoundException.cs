using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    [Serializable]
    class ArticleNotFoundException : Exception
    {
        public ArticleNotFoundException()
        { }

        public ArticleNotFoundException(string message)
            : base(message)
        { }

        public ArticleNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
