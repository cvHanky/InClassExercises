using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Meddelsessystem_med_delegates.Interfaces
{
    public interface INotifyMessageChanged
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler MessageChanged;
    }
}
