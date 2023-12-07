using PR33ObserverPattern3;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public class Academy : Organization, INotifyMessageChanged
    {
        #region Field
        //public Notifyhandler MessageChanged;
        //private List<NotifyHandler> observers = new List<NotifyHandler>();
        #endregion

        #region Property
        private string message;


        public string Message
        {
            get { return message; }
            set { message = value; OnMessageChanged(); }
        }

        #endregion




        public Academy(string name, string address) : base(name)
        {
            Address = address;

        }

        //public void Attach(IObserver o)
        //{
        //    students += o.Update;
        //}

        //public void Detach(IObserver o)
        //{
        //    students -= o.Update;
        //}

        public void OnMessageChanged()
        {
            MessageChanged(this, null);
        }

        public event INotifyMessageChanged.EventHandler MessageChanged;
    }
}
