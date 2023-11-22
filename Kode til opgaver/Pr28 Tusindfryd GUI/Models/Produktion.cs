using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr28_Tusindfryd_GUI.Models
{
    public class Produktion
    {
        public Drivhus PDrivhus { get; set; }
        public Produktionsbakke PBakke { get; set; }
        public Blomstersort PBlomst { get; set; }
        public DateTime StartDato { get; set; }
        public int StartAntal { get; set; }

        public Produktion(Drivhus pDrivhus, Produktionsbakke pBakke, Blomstersort pBlomst, DateTime startDato, int startAntal)
        {
            PDrivhus = pDrivhus;
            PBakke = pBakke;
            PBlomst = pBlomst;
            StartDato = startDato;
            StartAntal = startAntal;
        }
    }
}
