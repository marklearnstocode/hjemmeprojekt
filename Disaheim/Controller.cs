using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private ValuableRepository valueableRepo;

        public ValuableRepository ValueableRepo
        {
            get { return valueableRepo; }
            set { valueableRepo = value; }
        }

        public Controller()
        {
            valueableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            valueableRepo.AddValuable(valuable);
        }
    }
}
