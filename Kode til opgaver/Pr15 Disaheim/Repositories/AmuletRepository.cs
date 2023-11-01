//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pr15_Disaheim
//{
//    public class AmuletRepository
//    {
//        private List<Amulet> amulets = new List<Amulet>();

//        public void AddAmulet(Amulet amulet)
//        {
//            amulets.Add(amulet);
//        }
//        public Amulet? GetAmulet(string itemId)
//        {
//            Amulet? amulet = null;
//            if (amulets.Count > 0)
//            {
//                foreach (Amulet b in amulets)
//                {
//                    if (b.ItemId == itemId)
//                    {
//                        amulet = b; break;
//                    }
//                }
//            }
//            return amulet;
//        }
//        public Double GetTotalValue()
//        {
//            Utility utility = new Utility();
//            Double totalValue = 0;
//            foreach (Amulet b in amulets)
//            {
//                totalValue += utility.GetValueOfAmulet(b);
//            }
//            return totalValue;
//        }
//    }
//}
