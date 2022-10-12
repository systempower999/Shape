using Shape.Декорат.Декорат_круга;
using Shape.Декорат.Декорат_овала;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TestShape.Ploshad();
            Console.WriteLine("Стратегия ↓↓↓↓");
            Circle circle = new Circle(15);
            Rectangle rectangle = new Rectangle(20, 5);
            Triangle triangle = new Triangle(5,5,5);

            Painter painter = new Painter(circle);//паттерн стратегии
            painter.Drawn();
            Console.WriteLine("Круг идеальный");
            
            painter.ADrawn = rectangle;//паттерн стратегии
            painter.Drawn();
            Console.WriteLine("Прямоугольник идеальный");

            painter.ADrawn = triangle;//паттерн стратегии
            painter.Drawn();
            Console.WriteLine("Треугольник без косяков");

            Console.WriteLine();
            Console.WriteLine("Декорат ↓↓↓↓");
            Console.WriteLine();

            IDrawn oval = new Oval("Фигура овал");//декорат
            oval = new OvalWithKREST(oval);
            oval = new OvalWithRadius(oval);

            Console.WriteLine(oval.Drawn());
        }
    }
}
