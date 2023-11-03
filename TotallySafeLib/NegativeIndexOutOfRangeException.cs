using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallySafeLib
{
    public class NegativeIndexOutOfRangeException : Exception
    {
        public NegativeIndexOutOfRangeException() : base("Det må ikke være minus dumme. der er buksevand i farvandet.")

        {

        }
        public NegativeIndexOutOfRangeException(string message) : base(message)
        {

        }
        public NegativeIndexOutOfRangeException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
