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
            List<product> newProducts = new List<product>
                {
                    new product("Havre Gryn", "Svenska farm", 50, 19.50),
                    new product("Bread", "Bread from the bakery", 20, 25.5),
                    new product("Water", "From Alp , Italy", 20, 21.9)
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
            string target = "Water";
            Console.WriteLine("**********Sök efter en produkt********");
            int result = Inventory.SearchProduct(newProducts, target);
            if (result != -1)
            {
                Console.WriteLine("Product found at index: " + result);
            }
            else
            {
                Console.WriteLine("Product not found");
            }

            //updated amount of a product
            Console.WriteLine("**********Uppdatera mängden av en produkt********");
            newProducts[0].UpdateAmount(10); //acess the first product in the list and update the amount of the product.
            inventory.ShowProducts(); //print out all products to show how many products are left after updating the amount of a product.
        }
    }
}
