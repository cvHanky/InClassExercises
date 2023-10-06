using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim
{
    public class Amulet
    {
        public string ItemId { get; set; }
        public string? Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId, Level quality,string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId,quality,null)
        { }
        public Amulet(string itemId) : this (itemId, Level.medium,null)
        { }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }



        public Amulet(string itemId, string design, Level quality)
        {
            ItemId= itemId;
            Design = design;
            Quality = quality;
        }
    }
}
