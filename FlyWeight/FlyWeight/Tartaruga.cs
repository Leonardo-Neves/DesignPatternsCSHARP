using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    abstract class Tartaruga
    {
        private string _acao;
        private string _condicao;
        public string Cor { get; set; }

        public abstract void Mostrar();
    }
}
