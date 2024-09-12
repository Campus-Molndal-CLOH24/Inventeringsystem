using Inventeringsystem.Data;
using Inventeringsystem.Utill;

namespace Inventeringsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inventory class
            Inventory inventory = new Inventory(); //skap objekt av klassen Inventory
            inventory.AddProduct(new Product("Milk", "Milk from the farm", 10, 10.5)); //lägg till produkten i listan
            inventory.AddProduct(new Product("Havre Gryn", "Svenska farm", 50, 19.50));
            inventory.AddProduct(new Product("Bread", "Bread from the bakery", 20, 25.5));
            inventory.AddProduct(new Product("Butter", "Butter from the farm", 30, 15.5));
            inventory.ShowProducts(); //print out all products

            inventory.RemoveProduct("Milk");//ta bort produkten från listan
            Console.WriteLine("**********Produkter som är kvar********");
            inventory.ShowProducts(); //print out all products 

            string target = "Havre Gryn";
            int result = inventory.SearchProduct(target); 

            if (result >= 0)
            {
                Console.WriteLine($"Product found at index : {result}");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
    }
}
