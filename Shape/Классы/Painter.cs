using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Painter//художник
    {
        public IDrawn ADrawn { get; set; }
        public Painter(IDrawn drawn)
        {
            ADrawn = drawn;
        }


        public void Drawn()
        {
            ADrawn.Drawn();
        }
    }
}
