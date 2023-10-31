using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise? GetMerchandise(string itemId)
        {
            Merchandise? merchandise = null;
            if (merchandises.Count > 0)
            {
                foreach (Merchandise m in merchandises)
                {
                    if (m.ItemId == itemId)
                    {
                        merchandise = m; break;
                    }
                }
            }
            return merchandise;
        }
        public Double GetTotalValue()
        {
            Utility utility = new Utility();
            Double totalValue = 0;
            foreach (Merchandise m in merchandises)
            {
                totalValue += utility.GetValueOfMerchandise(m);
            }
            return totalValue;
        }
        public Double GetTotalValueOfBooks()
        {
            Utility utility= new Utility();
            Double totalValueOfBooks = 0;
            foreach (Merchandise m in merchandises)
            {
                if (m is Book)
                {
                    totalValueOfBooks += utility.GetValueOfMerchandise(m);
                }
            }
            return totalValueOfBooks;
        }
        public Double GetTotalValueOfAmulets()
        {
            Utility utility= new Utility();
            Double totalValueOfAmulets = 0;
            foreach (Merchandise m in merchandises)
            {
                if (m is Amulet)
                {
                    totalValueOfAmulets += utility.GetValueOfMerchandise(m);
                }
            }
            return totalValueOfAmulets;
        }
    }
}
