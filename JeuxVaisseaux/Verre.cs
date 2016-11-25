using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Verre:CMatieres
    {
        int nbVerre;
        public Verre(int nbMatiere) { nbVerre = nbMatiere; }

        public int getVerre
        {
            get { return nbVerre; }
        }

        public int setVerre
        {
            set { nbVerre = value; }
        }
    }
}
