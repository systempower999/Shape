using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        public abstract double CountArea();
        public abstract void Paint();//декорат
        public abstract void Draw();
        public virtual void Fill()
        {
            Console.WriteLine("Закрасить");
        }

    }

    


}
