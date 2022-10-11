using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle : Shape, IDrawn
    {
        public double R;
        private const double Pi = 3.14;

        public void Drawn()//интерфейс
        {
            Console.WriteLine("Нарисован круг");
        }

        public Circle(double r)
        {
            R = r;
        }

        public override double CountArea()//вычисление площади
        {
            return Pi * R * R;
        }

        public override void Paint()//декорат
        {
            Console.WriteLine("Художник нарисовал круг");
        }

        public override void Draw()
        {
            Console.WriteLine("Рисует круг площадью" + R);
        }
        public override void Fill()
        {
            Console.WriteLine("Заливка круга" + Color.black);
        }


    }
}
