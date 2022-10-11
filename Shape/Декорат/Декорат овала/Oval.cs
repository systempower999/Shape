using Shape.Декорат.Декорат_круга;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Декорат.Декорат_овала
{
    public class Oval : IDrawn//декорат
    {
        public string Name { get; protected set; }

        public Oval(string name)
        {
            Name = name;
        }

        public void Drawn()
        {
            Console.WriteLine("Овал нарисован ");
        }
    }
}
