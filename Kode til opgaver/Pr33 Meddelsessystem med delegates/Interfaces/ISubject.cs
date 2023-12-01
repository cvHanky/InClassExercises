using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr33_Meddelsessystem_med_delegates.Interfaces
{
    public interface ISubject
    {
        public void Attach(IObserver o);
        public void Detach(IObserver o);
        public void Notify();
    }
}
