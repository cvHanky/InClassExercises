using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim.Objects
{
    public class Amulet : Merchandise
    {
        public string? Design { get; set; }
        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, null)
        { }
        public Amulet(string itemId, string design) : this(itemId, Level.low, design)
            { }
        public Amulet(string itemId) : this(itemId, Level.medium, null)
        { }
        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;
                default:
                    return 0;
            }
        }
        public static Level StringToLevel(string level)
        {
            if (level.ToUpper() == "LOW")
                return Level.low;
            else if (level.ToUpper() == "MEDIUM")
                return Level.medium;
            else if (level.ToUpper() == "HIGH")
                return Level.high;
            else 
                return Level.low;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
