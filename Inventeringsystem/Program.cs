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

            //add products to the list
            List<Product> newProducts = new List<Product>
            {
                new Product("Havre Gryn", "Svenska farm", 50, 19.50),
                new Product("Bread", "Bread from the bakery", 20, 25.5),
                new Product("Bread", "Bread from the bakery", 20, 10.9)
            };
            inventory.AddProduct(newProducts);
            inventory.ShowProducts(); //print out all products to test if they are added to the list.

            //Remove product
            inventory.RemoveProduct("Milk");//ta bort produkten från listan
            Console.WriteLine("**********Produkter som är kvar********");
            inventory.ShowProducts(); //print out all products 
 
            // Sort products by price
            inventory.SortProducts(newProducts);
            Console.WriteLine("Sort product by price : ");
            foreach (var product in newProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

            //search product by name.
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
