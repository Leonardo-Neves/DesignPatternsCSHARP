using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica_FlyWeight fabrica = new Fabrica_FlyWeight();

            fabrica.GetTartaruga("vermelho");
            fabrica.GetTartaruga("azul");
            fabrica.GetTartaruga("verde");
            fabrica.GetTartaruga("laranja");

        }
    }
}
