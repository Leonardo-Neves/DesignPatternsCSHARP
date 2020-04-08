using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod  fm = FactoryMethod.GetInstancia;

            Console.Write("Escolha o personagem:");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);

            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
