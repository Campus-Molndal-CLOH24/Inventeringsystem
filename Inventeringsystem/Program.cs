using Inventeringsystem.Data;
using Inventeringsystem.Utill;
using System.Globalization;

namespace Inventeringsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inventory class
            //skap objekt av klassen Inventory
            Inventory inventory = new Inventory();

            Menu menu = new Menu(inventory);  // The Menu  access to myInventory
            menu.ShowMenu();  // The menu can now interact with the inventory
        }
    }
}

