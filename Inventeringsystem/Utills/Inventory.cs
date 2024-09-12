using Inventeringsystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventeringsystem.Utill
{
    public class Inventory
    {
        List<Product> products;

        //konstruktor för att skapa en lista av produkter
        public Inventory()
        {
            products = new List<Product>();
        }

        //metoder for att lägga till 
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        //ta bort en produkt
        public void RemoveProduct(string name)
        {
            //om det finns ingen produkt här returnera null
            if (products == null) return;
            //annas kör man en foreach loop för att hitta produkten sen ta bort den från listan
            foreach (var product in products)
            {
                if (product.Name == name) // om user uppger namnet med stora bokstäver så konvertera det till små bokstäver
                {
                    products.Remove(product);
                    break;
                }
            }
        }

        //metod för att visa alla produkter
        public void ShowProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Description: {product.Description}, Quantity: {product.Amount}, Price: {product.Price}");
            }
        }

        // Seach for a product by using seach algorithm()
        public void SearchProduct(List<Product> products, string name) 
        {
            
            
        }
        //updated quantity of a product
    }
}
