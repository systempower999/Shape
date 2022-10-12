using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : Shape, IDrawn
    {
        private double Dlina, Shirina;

        public string Drawn()//интерфейс
        {
            return "Нарисован прямоугольник";
        }

        public Rectangle(double a, double b)
        {
            Dlina = a;
            Shirina = b;
        }

        public override double CountArea()//вычисление площади
        {
            return Dlina * Shirina;
        }

        public override void Paint()
        {
            Console.WriteLine("Художник нарисовал прямоугольник");
        }
        public override void Draw()
        {
            Console.WriteLine("Рисует прямоугольник" + Dlina + "на" + Shirina);
        }

        public override void Fill()
        {
            Console.WriteLine("Заливка прямоугольника " + Color.white);
        }
    }
}
