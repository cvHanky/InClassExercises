using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TotallySafeLib
{
    public class NegativeIndexOutOfRange : Exception
    {
        public NegativeIndexOutOfRange()
        {
        }

        public NegativeIndexOutOfRange(string? message) : base(message)
        {
        }

        public NegativeIndexOutOfRange(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NegativeIndexOutOfRange(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
