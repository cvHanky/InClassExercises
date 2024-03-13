using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr49_Scheduling
{
    public enum ProcessStateType
    {
        New, Ready, Running, Waiting, Terminated
    }
    public class PCB
    {
        public string ProcessName { get; set; }
        public int ProcessPriority { get; set; }
        public ProcessStateType ProcessState { get; set; }

        public PCB(string processName, int processPriority, ProcessStateType processState)
        {
            this.ProcessName = processName;
            this.ProcessPriority = processPriority;
            this.ProcessState = processState;
        }

        public override string ToString()
        {
            return $"{ProcessName}({ProcessPriority})";
        }
    }
}
