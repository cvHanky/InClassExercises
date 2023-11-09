using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr21_tusindfryd
{
    public class Controller
    {
        private FlowerRepository flowerRepo;
        public Controller() 
        {
            flowerRepo = new FlowerRepository();
        }
        public void AddToList(string name, int productionTimeInDays, Double halfChangeValue, Double size)
        {
            Flower f = new Flower(name, productionTimeInDays, halfChangeValue, size);
            flowerRepo.AddFlower(f);
        }
    }
}
