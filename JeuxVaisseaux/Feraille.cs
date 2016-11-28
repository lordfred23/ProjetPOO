using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Feraille:CMatieres
    {
        int nbFeraille;
        public Feraille(int nbMatiere) { nbFeraille = nbMatiere; }

        public int getFeraille
        {
            get { return nbFeraille; }
        }

        public int setFeraille
        {
            set { nbFeraille = value; }
        }
    }
}
