using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Triangle : Shape, IDrawn 
    {
        private double A, B, C;

        public string Drawn()//интерфейс
        {
            return "Нарисован треугольник";
        }

        public Triangle(int a, int b, int c)
        {
            A = a; B = b; C = c;
        }

        public override double CountArea()//вычисление площади
        {
            double p = (A+B+C) /2;
            double S = Math.Sqrt(p*(p - A) * (p - A) * (p - A));
            return S;
            
        }
        public override void Paint()
        {
            Console.WriteLine("Художник нарисовал треугольник");
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем треугольник" + A + "на"+ B + "на" + C);
        }

        public override void Fill()
        {
            Console.WriteLine("Заливка треугольника " + Color.gray);
        }
    }
}
