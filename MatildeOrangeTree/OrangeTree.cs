using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatildeOrangeTree
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;

        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight() 
        {
            return height;
        }
        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;

        }
        public bool GetTreeAlive() 
        {
            return treeAlive;
        }
        public int GetNumOranges () 
        {
        return numOranges;
        }
        public int GetOrangesEaten () 
        {
            return orangesEaten;
        }
        public void OneYearPasses()
        {


            //for (int i = 0; i < 80; i++) 
            //{
            //    age += 1;
            //    height += 2;
            //    treeAlive = true;
            //    numOranges = age * 5 - 5;

            //}
            age++;
            numOranges = 0;
                numOranges = age * 5 - 5;
            if (age < 80)
            {
                height += 2;
                
            }
            else if (age >= 80)
            {
                treeAlive = false;
                numOranges = 0;
            }

        }
        public void EatOrange(int count)
        {
            if (numOranges > 0) 
            {
                count += orangesEaten;
            }
        }
    }
}
