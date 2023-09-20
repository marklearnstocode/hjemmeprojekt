using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    public class Menu
    {
        public string Title;
        private MenuItem[] menuItems;
        private int itemCount = 0;
        public Menu()
        {
            menuItems = new MenuItem[10];
        }
        public void Show()
        {
            Console.WriteLine(Title + "\n");

            for (int i = 0; i < itemCount; i++)
                Console.WriteLine(menuItems[i].Title);
            Console.WriteLine("\n" + "(Tryk menupunkt eller 0 for at afslutte) ");
        }
        public void AddmenuItem(string menuTitle)
        {
            MenuItem mi = new MenuItem();
            mi.Title = menuTitle;
            menuItems[itemCount] = mi;
            itemCount++;
        }
    }
}
