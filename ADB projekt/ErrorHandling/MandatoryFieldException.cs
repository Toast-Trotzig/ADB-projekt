using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADB_projekt
{
    class MandatoryFieldException: Exception
    {
        public MandatoryFieldException()
        {
        }

        public MandatoryFieldException(string message)
            : base(message)
        {
        }

        public MandatoryFieldException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
