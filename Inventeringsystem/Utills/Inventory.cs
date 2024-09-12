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
        private List<Product> products { get; set; }

        //konstruktor för att skapa en lista av produkter
        public Inventory()
        {
            products = new List<Product>(); // Initialize the list
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

        // Seach for a product by using linear search algorithm()
        public int SearchProduct(string target)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == target) // Name feom Product class
                {
                    return i;
                }
            }
            return -1; // Return -1 if the product is not found
        }
        //updated quantity of a product
    }
}
