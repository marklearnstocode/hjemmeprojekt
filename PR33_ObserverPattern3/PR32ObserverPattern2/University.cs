using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public class University : Organization 
    {
        #region Constructor
        public University(string name) : base(name)
        {
        }
        #endregion
    }
}
