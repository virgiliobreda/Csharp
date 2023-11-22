using AbstractMethod.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, ColorEnum color) 
            : base(color)
        {
            Radius = radius; 
        }

        public override double Area()
        {
            return Math.PI * (Radius * Radius);
        }

    }
}
