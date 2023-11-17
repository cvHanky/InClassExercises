using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr26_WPFandMVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string myLabelText = "Text not set yet.";
        public string MyLabelText
        {
            get { return myLabelText; }
            set 
            { 
                myLabelText = value;
                OnPropertyChanged("MyLabelText");
            }
        }

        private string myTextBoxText = "Text not set yet.";
        public string MyTextBoxText
        {
            get { return myTextBoxText; }
            set 
            { 
                myTextBoxText = value; 
                OnPropertyChanged("MyTextBoxText");
            }
        }

        private string myTextBoxClone;

        public string MyTextBoxClone
        {
            get { return myTextBoxClone; }
            set 
            {
                myTextBoxClone = myTextBoxText;
                OnPropertyChanged("MyTextBoxClone");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
