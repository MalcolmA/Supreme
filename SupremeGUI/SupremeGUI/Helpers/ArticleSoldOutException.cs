using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    [Serializable]
    class ArticleSoldOutException : Exception
    {
        public ArticleSoldOutException()
        { }

        public ArticleSoldOutException(string message)
            : base(message)
        { }

        public ArticleSoldOutException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
