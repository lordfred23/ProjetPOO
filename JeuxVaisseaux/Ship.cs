using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Ship
    {
        private int _numero, _papier, _verre, _plastique, _ferraille, _terreConta, _poidMax;
        public Ship(int numero){
            _papier = 1;
            _verre = 1;
            _plastique = 1;
            _ferraille = 1;
            _terreConta = 1;
        }

        public Ship(int numero, int papier, int verre, int plastique, int ferraille, int terreConta){
            _papier = papier;
            _verre = verre;
            _plastique = plastique;
            _ferraille = ferraille;
            _terreConta = terreConta;
        }
        public int getNumero
        {
            get { return _numero; }
        }

        public int getPoidMax
        {
            get { return _poidMax; }
        }

        public int getPapier
        {
            get { return _papier; }
        }

        public int getVerre
        {
            get { return _verre; }
        }

        public int getPlastique
        {
            get { return _plastique; }
        }

        public int getFerraille
        {
            get { return _ferraille; }
        }

        public int getTerreConta
        {
            get { return _terreConta; }
        }
    }
}
