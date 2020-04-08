using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Fabrica_FlyWeight
    {
        private Dictionary<string, Tartaruga> lista_de_tartaruga = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if (lista_de_tartaruga == null)
            {
                t = lista_de_tartaruga[cor]; 
                // Se já houver alguma instância dessa cor, vai ser usado o 
                // objeto que já foi instanciado da lista de tartaruga
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        t = new Azul();
                        break;
                    case "vermelho":
                        t = new Vermelho();
                        break;
                    case "verde":
                        t = new Verde();
                        break;
                    case "laranja":
                        t = new Laranja();
                        break;
                }
                // Se caso não tiver uma instância, vai ser criado uma instancia baseado 
                // na cor que foi passado para o metodo
            }
            return t;
        }
    }
}
