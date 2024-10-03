using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosInterface
{
    public class helicoptero : Ipairar, Imaquina
    {
        public void abastecer()
        {
            Console.WriteLine("ele abastece  o tanque");

        }

        public void Alertar()
        {
            Console.WriteLine("ele alerta");

        }

        public void cair()
        {
            Console.WriteLine("ele cai sem combustivel");

        }

        public void decola()
        {
            Console.WriteLine("ele decola");

        }

        public void desligar()
        {
            Console.WriteLine("ele delsiga o motor");

        }

        public void ligar()
        {
            Console.WriteLine("ele liga o motor");

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
