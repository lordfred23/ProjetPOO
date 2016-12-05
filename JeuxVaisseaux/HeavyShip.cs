using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class HeavyShip:Ship
    {
        private int _numero;
        public HeavyShip(int numero):base()
        {
            _numero = numero;
        }

        public HeavyShip(int papier, int verre, int plastique, int ferraille, int terreConta) : base(papier, verre, plastique, ferraille, terreConta, 367)
        { }

        public int getNumero
        {
            get { return _numero; }
        }
    }
}
