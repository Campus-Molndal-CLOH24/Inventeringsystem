﻿using Inventeringsystem.Data;
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

        //konstruktor för att skapa en lista av produkter and initialize the list
        public Inventory()
        {
            products = new List<Product>(); 
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
                Console.WriteLine($"Name: {product.Name}, Description: {product.Description}, Quantity: {product.Amount}, Price: {product.Price}");
            }
        }

        //sortera produkter efter namn
        public void SortProducts(List<Product> products)
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
