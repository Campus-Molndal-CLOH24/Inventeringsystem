using Inventeringsystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inventeringsystem.Utill
{
    public class Inventory
    {
        private List<Product> products { get; set; }

        //konstruktor för att skapa en lista av produkter and initialize the list
        public Inventory()
        {
            products = new List<Product>(); 
        }
        //becuase the products is private we need to create a method to get the products list.
        public List<Product> GetProducts()
        {
            return products;
        }

        //metoder for att lägga till 
        public void AddProduct(List<Product> NewProduct)
        {
            products.AddRange(NewProduct);
        }

        //ta bort en produkt
        //använder vilkor om det finns ingen produkt här returnera null, no action needed.
        //annas kör man en foreach loop för att hitta produkten sen ta bort den från listan
        // använder if satsen om  user uppger namnet med stora bokstäver så konvertera det till små bokstäver
        //then ta bort produkten från listan.
        public void RemoveProduct(string name)
        {
            if (products == null) return;
            foreach (var product in products)
            {
                if (product.Name == name) 
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
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Amount}, Price: {product.Price}");
            }
        }

        //sortera produkter efter name
        // Yttre loop för att gå igenom varje produkt i listan.
        // Anta att första elementet är det minsta
        // Inre loop för att jämföra varje produkt med varandra.
        // Jämför produktnamn (case-sensitive)
        public void SortProducts()
        {
            
            for (int i = 0; i < products.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < products.Count; j++)
                {
                    if (string.Compare(products[j].Name, products[min].Name) < 0)
                    {
                        
                        min = j; // Uppdatera index för den minsta produkten
                    }
                }
                //Byt plats på den minsta funna produkten och den aktuella produkten.
                Product temp = products[i];
                products[i] = products[min];
                products[min] = temp;
            }
            
        }

        // Metod för att söka efter en produkt med hjälp av en binär sökning baserad på namn 
        public int SearchProduct(string target)
        {
            // Se till att listan är sorterad innan sökning
            SortProducts();
            int left = 0;
            int right = products.Count - 1;
            while (left <= right)
            {
                // Hitta mittenindex
                int middle = left + (right - left) / 2;
                // Konvertera mittenproduktens namn till små bokstäver för att undvika skillnader i versaler/gemeneon
                string middleName = products[middle].Name.ToLower();

                if (middleName == target) //if the target is found return the index of the target
                {
                    return middle;
                }
                else if (string.Compare(middleName, target) < 0) // Convert both to lowercase to handle case-insensitive comparison
                {
                    left = middle + 1; // If target greater, ignore left half
                }
                else
                {
                    right = middle - 1; // If target is smaller, ignore right
                }
            }
            return -1;
        }
        

    }
}
