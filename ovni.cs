using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosInterface
{
    public class ovni : Ipairar
    {
        public void cair()
        {
            Console.WriteLine("ele cai");

        }

        public void decola()
        {
            Console.WriteLine("ele decola");

        }

        public void pairar()
        {
            Console.WriteLine("ele para no ar");

        }

        public void planar()
        {
            Console.WriteLine("ele plana");

        }

        public void pousar()
        {
            Console.WriteLine("ele pousa");

        }
    }
}
