using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim
{
    public class Amulet : Merchandise
    {
        public string? Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId,Level quality, string design)
        {
            base.ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId,quality,null)
        { }
        public Amulet(string itemId) : this (itemId, Level.medium,null)
        { }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
