using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosInterface
{
    public class trem : Imaquina
    {
        public void abastecer()
        {
            Console.WriteLine("ele abastece o tanque");
        }

        public void Alertar()
        {
            Console.WriteLine("ele alerta"); ;
        }

        public void desligar()
        {
            Console.WriteLine("ele desliga o motor");
        }

        public void ligar()
        {
            Console.WriteLine("ele liga o motor");
        }
    }
}
