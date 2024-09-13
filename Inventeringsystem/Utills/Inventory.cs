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
        public void SortProducts()
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
                Product temp = products[i];
                products[i] = products[min];
                products[min] = temp;
            }
        }

        // Seach for a product by using binary search algorithm() , searching by name. 
        public int SearchProduct(string target)
        {
            // Ensure the list is sorted before searching
            SortProducts();

            // Convert target to lowercase for case-insensitive search
            target = target.ToLower();
            int left = 0;
            int right = products.Count - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2; 
                // Check if target is present at midle
                 // Convert product name to lowercase for case-insensitive comparison
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
