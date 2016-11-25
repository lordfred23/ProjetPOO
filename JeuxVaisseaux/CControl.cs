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
            Cree_Vaisseaux(choix);
            Cree_Centre_trie(choix);
        }
        private void Cree_Vaisseaux(int choix)
        {

        }

        private void Remplir_vaisseaux()
        {

        }

        private void Cree_Centre_trie(int choix)
        {

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
