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
        private List<product> products { get; set; }

        //konstruktor för att skapa en lista av produkter and initialize the list
        public Inventory()
        {
            products = new List<product>(); 
        }
        //becuase the products is private we need to create a method to get the products list.
        public List<product> GetProducts()
        {
            return products;
        }

        //metoder for att lägga till 
        public void AddProduct(List<product> NewProduct)
        {
            products.AddRange(NewProduct);
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
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Amount}, Price: {product.Price}");
            }
        }

        //sortera produkter efter price
        public void SortProducts(List<product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                // assign the middle element of the array to the min variable
                int min = i;
                for (int j = i + 1; j < products.Count; j++)
                {
                    if (products[j].Price < products[min].Price)
                    {
                        min = j;
                    }
                }
                //Swap the found minimum element with the first element from products class
                product temp = products[i];
                products[i] = products[min];
                products[min] = temp;
            }
        }

        // Seach for a product by using binary search algorithm() , searching by name. 
        public int SearchProduct(List<product> products, string target)
        {
            
            int left = 0;
            int right = products.Count - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2; // Corrected calculation
                // Check if target is present at midle
                if (products[middle].Name == target) //if the target is found return the index of the target
                {
                    return middle;
                }
                else if (string.Compare(products[middle].Name, target) < 0) // Convert both to lowercase to handle case-insensitive comparison
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
