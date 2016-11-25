using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class LightShip:Ship
    {
        private int _numero,_poidMax = 108;
        //public LightShip(int numero):base()
        //{
        //    _numero = numero;
        //}

        public LightShip(int papier, int verre, int plastique, int ferraille, int terreConta) : base(papier, verre, plastique, ferraille, terreConta)
        { }

        public int getNumero
        {
            get { return _numero; }
        }

        public int getPoidMax
        {
            get { return _poidMax; }
        }
        public int setPoidMax
        { set { _poidMax = value; }  }
    }
}
