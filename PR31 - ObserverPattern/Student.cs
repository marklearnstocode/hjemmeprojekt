using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR31___ObserverPattern
{
    public class Student : Observer
    {
        private Academy subject;
		private string message;

		public string Message
		{
			get { return message; }
			set { message = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
		}
		public Student(Academy subject, string name)
		{
			this.subject = subject;
			this.name = name;
		}

        public override void Update()
        {
            message = subject.Message;
			Console.WriteLine(Name + " " + Message + " fra " + subject.Name);
        }
    }
}
