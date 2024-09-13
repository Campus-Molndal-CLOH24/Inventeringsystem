using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventeringsystem.Utill;

namespace Inventeringsystem.Data
{
    public class product
    {//klass variabler
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        // Constructor for each products
        public product(string name, int amount, double price)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
        }
    }

}
