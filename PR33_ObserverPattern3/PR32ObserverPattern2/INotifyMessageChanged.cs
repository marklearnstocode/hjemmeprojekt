using PR32ObserverPattern2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR33ObserverPattern3
{
    public interface INotifyMessageChanged
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler MessageChanged;

      
    }
}
