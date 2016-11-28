

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class CControl
    {
        Random rnd = new Random();
        public CControl()
        { }

        public void Jouer(int choix)
        {
            if (choix == 0)
                Environment.Exit(0);
            Determiner_NombreVaisseaux(choix);
            //test du push
            
        }
        private void Determiner_NombreVaisseaux(int choix)
        {
            Cree_Vaisseaux(choix * 100);
            Cree_Centre_trie(choix);


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

        }

        private int[] Remplir_vaisseaux(int reste)
        {
            int rest,i;
            int[] tabRess = new int[5];

           rest = reste;
            for (i = 4; i>=0; i--)
            {
                if(i>=1)
                {
                    tabRess[4 - i] = rnd.Next(1, rest - i);
                    rest = rest - tabRess[4 - i];
                }
                else
                {
                    tabRess[4 - i] = rest;
                    rest = rest - tabRess[4 - i];
                }
                
            }
            return tabRess;



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
