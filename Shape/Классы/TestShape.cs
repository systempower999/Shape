using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class TestShape
    {
        public static void Ploshad()
        {
            List<Shape> list = new List<Shape>();
            list.Add(new Circle(15));
            list.Add(new Rectangle(20, 5));
            list.Add(new Triangle(5, 5, 5));

            foreach (var shape in list)
            {
                if (shape is Circle)
                    Console.Write("Круг S = ");
                else if (shape is Rectangle)
                    Console.Write("Прямоугольник S = ");
                else if (shape is Triangle)
                    Console.Write("Треугольник S = ");

                Console.WriteLine(shape.CountArea());
            }
        }
    }
}
