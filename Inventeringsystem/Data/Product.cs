using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventeringsystem.Data
{
    public class product
    {//klass variabler
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        // Constructor for each products
        public product(string name, string description, int amount, double price)
        {
            this.Name = name;
            Description = description;
            Amount = amount;
            Price = price;
        }

        //updated amoung  of a product 
        public void UpdateAmount(int AdditionAmount)
        {
            if (AdditionAmount < 0)
            {
                throw new ArgumentException("Amount can not be negative");
            }
            Amount += AdditionAmount;
        }
    }

}
