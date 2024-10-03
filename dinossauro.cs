using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosInterface
{
    internal class dinossauro : Iservivo
    {
        public void comer()
        {
            Console.WriteLine("ele tem que comer");
        }

        public void dormir()
        {
            Console.WriteLine("ele dorme");
        }

        public void morrer()
        {
            Console.WriteLine("ele morre");
        }

        public void respirar()
        {
            Console.WriteLine("ele respira");
        }
    }
}
