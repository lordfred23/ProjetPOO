using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Terre:CMatieres
    {
        int nbTerre;
        public Terre(int nbMatiere) { nbTerre = nbMatiere; }

        public int getTerre
        {
            get { return nbTerre; }
        }

        public int setTerre
        {
            set { nbTerre = value; }
        }
    }
}
