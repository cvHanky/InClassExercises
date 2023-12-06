using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr34_Metronome_bonus
{
    public class TickListener
    {
        public void SoundHeard(object sender, EventArgs e)
        {
            if (sender is Metronome m)
            {
                Console.WriteLine("Sound heard.");
            }
        }
    }
}
