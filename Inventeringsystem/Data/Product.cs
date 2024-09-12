using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventeringsystem.Data
{
    public class Product
    {//klass variabler
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        // Constructor for each products
        public Product(string name, string description, int amount, double price)
        {
            this.Name = name;
            Description = description;
            Amount = amount;
            Price = price;
        }
    }

}
