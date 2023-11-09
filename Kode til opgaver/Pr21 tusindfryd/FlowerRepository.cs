using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_tusindfryd
{
    public class FlowerRepository
    {
        private List<Flower> flowers;
        public FlowerRepository() 
        {
            flowers = new List<Flower>();
        }
        public void AddFlower(Flower flower)
        {
            try
            {
                flowers.Add(flower);
                Console.WriteLine("Flower successfully added.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Flower was not added");
            }
        }
        public void RemoveFlower(Flower flower)
        {
            flowers.Remove(flower);
        }
        public void UpdateFlower(Flower flower)
        {
            // 
        }
    }
}
