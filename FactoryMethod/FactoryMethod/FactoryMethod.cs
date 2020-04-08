using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FactoryMethod
    {
        private static FactoryMethod _factoryMethod = null;

        public static FactoryMethod GetInstancia // Singleton
        {
            get
            {
                if (_factoryMethod == null)
                    _factoryMethod = new FactoryMethod();
                return _factoryMethod;
            }
            
        }
        public IPersonagem Escolher_Personagem(string personagem) // Factory Method
        {
            switch (personagem)
            {
                case "Liu Kang": return new KiuKang();
                case "Sub Zero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
