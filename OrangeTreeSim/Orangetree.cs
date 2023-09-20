using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            set

            {
                if (value > 0)
                    age = value;
                else age = 0;
            }
            get
            { return age; }
        }

        public int Height
        {
            set { height = value; }
            get { return height; }
        }

        public bool TreeAlive
        {
            set { treeAlive = value; }
            get { return treeAlive; }
        }
        public int NumOranges
        {
            get { return numOranges; }
        }

        public int OrangesEaten
        {
            get { return orangesEaten; }
        }
        public void OneYearPasses()
        {
            age++;
            orangesEaten = 0;
            numOranges = (age - 1) * 5;
            if (age < 80)
            {
                height += 2;
            }
            else
            {
                treeAlive = false;
                numOranges = 0;
            }
        }
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                numOranges -= count;
                orangesEaten += count;
            }
            else
            {
                Console.WriteLine("ikke nok appelsiner.");
            }
        }
    }
}
