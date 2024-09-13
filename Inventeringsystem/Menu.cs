using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventeringsystem.Data;
using Inventeringsystem.Utill;

namespace Inventeringsystem
{
    class Menu
    {
        //access to inventory class 
        private Inventory inventory;
        //construtor menu class 
        public Menu(Inventory inventory)
        {
            this.inventory = inventory;
        }
        //method to show menu
        public void ShowMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("====InventeringSystem för att hantera product i lager =======");
                Console.WriteLine("1. Lägg till produnkt");
                Console.WriteLine("2. ta bort produnkt");
                Console.WriteLine("3. Visa alla produkt");
                Console.WriteLine("4. Sök efter produkt");
                Console.WriteLine("5. Sortera produkt");
                Console.WriteLine("6. Avsluta");
                Console.Write("Välja alternativ : ");

                //läsa in användarens val
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        RemoveProduct();
                        break;
                    case "3":
                        ShowProducts();
                        break;
                    case "4":
                        SearchProduct();
                        break;
                    case "5":
                        SortProducts();
                        break;
                    case "6":
                        Console.WriteLine("Programmet avslutas");
                        return;
                    default:
                        Console.WriteLine("Fel val, försök igen");
                        break;

                }
            }
        }

        private void AddProduct()
        {
            Console.WriteLine("Ange Produkt : ");
            string name = Console.ReadLine();
            Console.WriteLine("Ange Amoung : ");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange Pris : ");
            //omvandla string till double med hjälp av CultureInfo.InvariantCulture for att undvika problem med decimaler
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            //skapa ett nytt objekt av klassen product                                                                               
            Product newProduct = new Product(name, amount, price);
            inventory.AddProduct(new List<Product> { newProduct });
            Console.WriteLine("Produkt hat lagt till.");
        }

        private void RemoveProduct()
        {
            Console.WriteLine("Ange produktnamn som du vill ta bort : ");
            string name = Console.ReadLine();
            inventory.RemoveProduct(name);
            Console.WriteLine("Produkt har tagits bort.");
        }
        //Show Products
        private void ShowProducts()
        {
            inventory.ShowProducts();
        }
        //Search method 
        private void SearchProduct()
        {
            Console.WriteLine("Ange produktnamn som du vill söka efter : ");
            string target = Console.ReadLine();
            //ensure it sorteing before searching
            inventory.SortProducts();
            int index = inventory.SearchProduct(target);
            if (index == -1)
            {
                Console.WriteLine("Produkt hittades inte.");
            }
            else
            {
                Console.WriteLine($"Produkt hittades på index {index}");
            }
        }
        // sorting product by name
        private void SortProducts()
        {
            inventory.SortProducts();
            Console.WriteLine($"Produkter har sorterats. : ");
            foreach (var product in inventory.GetProducts())
            {
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Amount}, Price: {product.Price}");
            }
        }
    }
 }

    

