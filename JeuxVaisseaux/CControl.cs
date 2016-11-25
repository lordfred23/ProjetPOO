using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class CControl
    {
        public CControl()
        { }

        public void Jouer(int choix)
        {
            if (choix == 0)
                Environment.Exit(0);
        }
        private void Cree_Vaisseaux(int choix)
        {

        }

        private void Remplir_vaisseaux()
        {

        }

        private void Cree_Centre_trie(int choix)
        {
            Ctri centreTri;
            List<Ctri> lstCentreTri = new List<Ctri>();
            for(int i = 1; i <= (choix*10); i++)
            {
                if ((i % 2) == 0)
                    centreTri = new Ctri(true);
                else
                    centreTri = new Ctri(false);
                lstCentreTri.Add(centreTri);
            }
        }

        private void Retour_Au_Depart()
        {

        }

        private void Compter_Matiere()
        {

        }

        private bool IsEven(int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }



    }

}
