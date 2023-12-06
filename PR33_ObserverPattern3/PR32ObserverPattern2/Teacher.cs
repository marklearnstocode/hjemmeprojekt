using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }

        public string JobTitle { get; set; }
    }
}
