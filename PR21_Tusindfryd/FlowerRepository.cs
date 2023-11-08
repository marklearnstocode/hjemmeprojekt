using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR21_Tusindfryd
{
    public class FlowerRepository
    {
        private List<Flower> _flowers = new List<Flower>();
        public FlowerRepository()
        {

        }
        public void AddFlower(Flower flower)
        {
            try
            {
            _flowers.Add(flower);
                Console.WriteLine("Flower successfully added");
            }
            catch (Exception e)
            {
                Console.WriteLine("Flower was not added");
            }
        }
        public void RemoveFlower(Flower flower)
        {
            _flowers.Add(flower);
        }
        public void UpdateFlower(Flower flower)
        {

        }

    }
}
