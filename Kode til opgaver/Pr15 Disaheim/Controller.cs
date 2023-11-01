using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr15_Disaheim.Objects;
using Pr15_Disaheim.Repositories;

namespace Pr15_Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuableRepo { get; set; }
        public Controller() 
        {
            ValuableRepo = new ValuableRepository();
        }
        public void AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable);
        }
    }
}
