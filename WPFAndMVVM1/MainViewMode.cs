using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace WPFAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string myLabelText = "Text not set yet";

        public string MyLabelText
        {
            get { return myLabelText; }
            set { myLabelText = value;
                OnPropertyChanged("MyLabelText");
            }
        }
        private string myTextBoxText = "Text not set yet";


        public string MyTextBoxText
        {
            get { return myTextBoxText; }
            set { myTextBoxText = value;
                OnPropertyChanged("MyTextBoxText");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
