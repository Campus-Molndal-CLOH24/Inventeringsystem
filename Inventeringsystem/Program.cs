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
            
            List<Product> newProducts = new List<Product>
            {
                new Product("Havre Gryn", "Svenska farm", 50, 19.50),
                new Product("Bread", "Bread from the bakery", 20, 25.5),
                new Product("Bread", "Bread from the bakery", 20, 25.5)
            };
            inventory.AddProduct(newProducts);
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
