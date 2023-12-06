using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public class Organization
    {
        #region Properties
        public string Name { get;  }

        public string Address { get; set; }

        #endregion

        public Organization(string name)
        {
            Name = name;
        }
    }
}
