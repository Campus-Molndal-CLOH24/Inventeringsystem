using Inventeringsystem.Data;
using Inventeringsystem.Utill;
using System.Globalization;

namespace Inventeringsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Inventory class
            //skap objekt av klassen Inventory
            Inventory inventory = new Inventory();

            while (true)
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
                        AddProduct(inventory);
                        break;
                    case "2":
                        RemoveProduct(inventory);
                        break;
                    case "3":
                        ShowProducts(inventory);
                        break;
                    case "4":
                        SearchProduct(inventory);
                        break;
                    case "5":
                        SortProducts(inventory);
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
        
        static void AddProduct(Inventory inventory)
        {
            Console.WriteLine("Ange Produkt : ");
            string name = Console.ReadLine();
            Console.WriteLine("Ange Amoung : ");
            int amount = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ange Pris : ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //omvandla string till double med hjälp av CultureInfo.InvariantCulture for att undvika problem med decimaler
            //skapa ett nytt objekt av klassen product
            product newProduct = new product(name, amount, price);
            inventory.AddProduct(new List<product> { newProduct });
            Console.WriteLine("Produkt hat lagt till.");
        }

        static void RemoveProduct(Inventory inventory)
        {
            Console.WriteLine("Ange produktnamn som du vill ta bort : ");
            string name = Console.ReadLine();
            inventory.RemoveProduct(name);
            Console.WriteLine("Produkt har tagits bort.");
        }

        static void ShowProducts(Inventory inventory)
        {
            inventory.ShowProducts();
        }

        static void SearchProduct(Inventory inventory)
        {
            Console.WriteLine("Ange produktnamn som du vill söka efter : ");
            string target = Console.ReadLine();
            //ensure it sorteing before searching
            inventory.SortProducts(inventory.GetProducts());
            int index = inventory.SearchProduct(inventory.GetProducts(), target);
            if (index == -1)
            {
                Console.WriteLine("Produkt hittades inte.");
            }
            else
            {
                Console.WriteLine($"Produkt hittades på index {index}");
            }
        }

        static void SortProducts(Inventory inventory)
        {
            inventory.SortProducts(inventory.GetProducts());
            Console.WriteLine($"Produkter har sorterats. : ");
            foreach (var product in inventory.GetProducts())
            {
                Console.WriteLine($"Name: {product.Name}, Quantity: {product.Amount}, Price: {product.Price}");
            }
        }
    }
}
