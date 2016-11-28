using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Papier:CMatieres
    {
        int nbPapier;
        public Papier(int nbMatiere) { nbPapier = nbMatiere; }

        public int getPapier
        {
            get { return nbPapier; }
        }

        public int setPapier
        {
            set { nbPapier = value; }
        }
    }
}
