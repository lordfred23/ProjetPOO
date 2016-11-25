using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Plastique:CMatieres
    {
        int nbPlastique;
        public Plastique(int nbMatiere) { nbPlastique = nbMatiere; }

        public int getPlastique
        {
            get { return nbPlastique; }
        }

        public int setPlastique
        {
            set { nbPlastique = value; }
        }
    }
}
