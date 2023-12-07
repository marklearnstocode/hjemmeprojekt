using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PR32ObserverPattern2
{
    public interface IObserver
    {
        public void Update(object sender, EventArgs e);
    }
}
