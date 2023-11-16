using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR21_Tusindfryd
{
    public class Controller
    {
        private FlowerRepository _flowerRepository;
        
        public Controller()
        {
            _flowerRepository = new FlowerRepository();
        }

        public void AddToList(string Name, int ProductionTimeInDays, double HalfChangeofValue, double Size)
        {
            Flower flower = new Flower(Name, ProductionTimeInDays, HalfChangeofValue, Size);
            _flowerRepository.AddFlower(flower); 
        }
    }
}
