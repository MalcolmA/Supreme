using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    [Serializable]
    class ArticleNotInitializedException : Exception
    {
        public ArticleNotInitializedException()
        { }

        public ArticleNotInitializedException(string message)
            : base(message)
        { }

        public ArticleNotInitializedException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
