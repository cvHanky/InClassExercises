using Pr33_Meddelsessystem_med_delegates.Interfaces;
using Pr33_Meddelsessystem_med_delegates.Superclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Meddelsessystem_med_delegates.Domain
{
    public delegate void NotifyHandler();
    public class Academy : Organization
    {
        public NotifyHandler MessageChanged;
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; OnMessageChanged(); }
        }


        public Academy(string name, string address) : base(name)
        {
        }

        public void OnMessageChanged()
        {
            MessageChanged.Invoke();
        }
    }
}
