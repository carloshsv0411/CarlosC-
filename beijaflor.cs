using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosInterface
{
    public class beijaflor : Ipairar, Iservivo
    {
        public void cair()
        {
            Console.WriteLine("ele cai");

        }

        public void comer()
        {
            Console.WriteLine("ele come");

        }

        public void decola()
        {
            Console.WriteLine("ele sobe");

        }

        public void dormir()
        {
            Console.WriteLine("ele dorme");

        }

        public void morrer()
        {
            Console.WriteLine("ele morre quando esta velho");

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
            Console.WriteLine("pousa");

        }

        public void respirar()
        {
            Console.WriteLine("ele tem que respirar pra viver");

        }
    }
}
