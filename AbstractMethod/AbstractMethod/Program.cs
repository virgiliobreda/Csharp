using AbstractMethod.Entities;
using AbstractMethod.Entities.Enums;
using System.Drawing;
using System.Globalization;

namespace AbstractMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                ColorEnum color = Enum.Parse<ColorEnum>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Entities.Rectangle(width, height, color));
                }

                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("Shape Areas: ");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}