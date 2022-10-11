using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Декорат.Декорат_круга
{
    public class OvalWithKREST : IDrawn//декорат
    {
        public IDrawn Oval { get; set; }

        public OvalWithKREST(IDrawn oval)
        {
            Oval = oval;
        }
        
        public void Drawn()
        {
            Console.WriteLine("с крестом");
        }
    }
}
