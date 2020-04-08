using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class KiuKang : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("Kiu Kang!");
        }
    }
}
