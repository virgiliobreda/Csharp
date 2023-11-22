using AbstractMethod.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractMethod.Entities
{
    abstract class Shape
    {
        public ColorEnum Color { get; set; }

        public Shape(ColorEnum color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
