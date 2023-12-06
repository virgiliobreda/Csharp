using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFilesExercise
{
    internal class Product
    {
        public string Name { get; set; }
        public double UnitaryPrice { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double unitaryPrice, int quantity) 
        {
            this.Name = name;
            this.UnitaryPrice = unitaryPrice;
            this.Quantity = quantity;
        }

        public double Total()
        {
            return UnitaryPrice * Quantity;
        }
    }
}
