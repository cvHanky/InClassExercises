using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr34_Metronome_bonus
{
    public delegate void TickEventHandler(object sender, EventArgs e);
    public class Metronome
    {
        public int Iterations { get; set; }
        public int TickLength { get; set; }

        public Metronome(int iterations, int tickLength) 
        {
            Iterations = iterations;
            TickLength = tickLength;
        }

        public event TickEventHandler Tick;
        public void OnTick()
        {
            if (Tick != null)
            {
                Tick(this, null);
            }
        }

        public void RunMetronome()
        {
            int iterations = 0;
            while (iterations < Iterations)
            {
                Thread.Sleep(TickLength * 1000);
                OnTick();
                iterations++;
            }
        }
    }
}
