using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class LightShip:Ship
    {
        private int _numero;
        public LightShip(int numero):base()
        {
            _numero = numero;
        }

        public LightShip(int papier, int verre, int plastique, int ferraille, int terreConta) : base(papier, verre, plastique, ferraille, terreConta, 108)
        { }

        public int getNumero
        {
            get { return _numero; }
        }
    }
}
