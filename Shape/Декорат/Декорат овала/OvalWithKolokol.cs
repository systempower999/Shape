using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Декорат.Декорат_круга
{
    public class OvalWithKolokol : IDrawn//декорат
    {
        public IDrawn Oval { get; set; }

        public OvalWithKolokol(IDrawn oval)
        {
            Oval = oval;
        }

        public string Drawn()
        {
            return Oval.Drawn() + "с колокольчиком ";
        }
    }
}
