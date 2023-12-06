using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public class Person
    {
        #region Properties
        public string Name { get; }
        #endregion


        #region Constructors
        public Person(string name)
        { 
            Name = name;
        }
        #endregion 
    }
}
