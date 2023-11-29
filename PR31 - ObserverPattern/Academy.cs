using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR31___ObserverPattern
{
    public class Academy : Subject
    {
        private string message = "Så er der julefrokost venner!";

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        private string name = "Fra akademiet UCL";

        public string Name
        {
            get { return name; }

        }
        public Academy(string name)
        {
            this.name = name;
        }

    }
}
