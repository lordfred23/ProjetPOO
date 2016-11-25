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
<<<<<<< HEAD
=======
<<<<<<< HEAD
            Determiner_NombreVaisseaux(choix);
            
>>>>>>> 7ef8e628f6aa17133c597de5bbe4365bfbb4689a
        }
        private void Cree_Vaisseaux(int choix)
        {
<<<<<<< HEAD
=======
            Cree_Vaisseaux(choix * 100);
            Cree_Centre_trie(choix);


=======
>>>>>>> origin/Alex
        }
        private void Cree_Vaisseaux(int nb)
        {
            int i,nbRandom;
            int[] tabRess;
            LightShip ls;
            HeavyShip hs;


            for (i=0;i<nb;i++)
            {
               nbRandom= rnd.Next(0, 2);
                if(nbRandom==0)
                {
                   tabRess= Remplir_vaisseaux(108);
                    ls  = new LightShip(tabRess[0], tabRess[1], tabRess[2], tabRess[3], tabRess[4]);
                    Console.WriteLine(i+" Light : "+ls.getPapier + " " + ls.getVerre + " "+ls.getPlastique+ " "+ls.getFerraille+ " "+ls.getTerreConta  );
                }
                else
                {
                    tabRess = Remplir_vaisseaux(367);
                    hs = new HeavyShip(tabRess[0], tabRess[1], tabRess[2], tabRess[3], tabRess[4]);
                    Console.WriteLine(i +" Heavy : " + hs.getPapier + " " + hs.getVerre + " " + hs.getPlastique + " " + hs.getFerraille + " " + hs.getTerreConta);
                }
                

            }
            Console.ReadLine();
>>>>>>> 7ef8e628f6aa17133c597de5bbe4365bfbb4689a

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
