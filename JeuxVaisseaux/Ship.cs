using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Ship
    {
        private int _papier, _verre, _plastique, _ferraille, _terreConta, _pdsMax;
        public Ship()
        {
            _papier = 1;
            _verre = 1;
            _plastique = 1;
            _ferraille = 1;
            _terreConta = 1;
        }

        public Ship(int papier, int verre, int plastique, int ferraille, int terreConta, int pdsMax){
            _papier = papier;
            _verre = verre;
            _plastique = plastique;
            _ferraille = ferraille;
            _terreConta = terreConta;
            _pdsMax = pdsMax;
        }

        public int getPapier
        { get { return _papier; } }
        public int setPapier
        { set { _papier = value; } }

        public int getVerre
        { get { return _verre; } }
        public int setVerre
        { set { _verre = value; } }

        public int getPlastique
        { get { return _plastique; } }
        public int setPlasique
        { set { _plastique = value; } }

        public int getFerraille
        { get { return _ferraille; } }
        public int setFerraille
        { set { _ferraille = value; } }

        public int getTerreConta
        { get { return _terreConta; } }
        public int setTerreConta
        { set { _terreConta = value; } }

        public int getPoidMax
        { get { return _pdsMax; } }
    }
}
