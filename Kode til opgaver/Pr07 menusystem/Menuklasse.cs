using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr07_menusystem
{
    public class Menu
    {
        public string Title;
        private int itemCount = 0;
        private MenuItem[] menuItems = new MenuItem[10];
        public Menu(string title)
        {
            Title = title;
        }

        public void AddMenuItem(string Content)
        {
            MenuItem mi = new MenuItem(Content);
            menuItems[itemCount] = mi;
            itemCount++;

        }
        public void Show()
        {
            Console.WriteLine(Title + "\n");
            for (int i = 0; i < itemCount;i++)
            {
                Console.WriteLine(menuItems[i].Title);
            }
            Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
        }

        public void SelectMenuItem(int choice)
        {
            switch (choice)
            {
                case 0: 
                    Console.Clear();
                    Console.WriteLine("Program afsluttet.");
                    break;
                case 1:
                    Console.Clear ();
                    Console.WriteLine("Gør dit.");
                    break;
                case 2: 
                    Console.Clear ();
                    Console.WriteLine("Gør dat.");
                    break;
                case 3: 
                    Console.Clear ();
                    Console.WriteLine("Gør noget.");
                    break;
                case 4:
                    Console.Clear ();
                    Console.WriteLine("42.");
                    break;
                default:
                    Console.WriteLine("Der opstod en fejl. ");
                    break;
            }
        }
        
    }
}
