using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public class Student : Person, IObserver
    {
        private string message;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        public Student(string name) : base(name)
        {

        }
        public void Update(object sender, EventArgs e)
        {
            if (sender is Academy a)
            {
                Message = a.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra {a.Name}");
            }
            //Message = academy.Message;
           
        }
    }
}
