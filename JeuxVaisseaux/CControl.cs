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
        Ctri[] tabCentreTri;
        Ship vaisseau;
        Stack<Ship> fileVaisseau = new Stack<Ship>();
        public CControl()
        { }

        public void Jouer(int choix)
        {
            if (choix == 0)
                Environment.Exit(0);
            Determiner_NombreVaisseaux(choix);
            Debut_Jeu(choix);
        }
        private void Determiner_NombreVaisseaux(int choix)
        {
            Cree_Vaisseaux(choix * 100);
            Cree_Centre_trie(choix);
        }
        private void Cree_Vaisseaux(int nb)
        {
            int i, nbRandom;
            int[] tabRess;
            LightShip ls;
            HeavyShip hs;


            for (i = 0; i < nb; i++)
            {
                nbRandom = rnd.Next(0, 2);
                if (nbRandom == 0)
                {
                    tabRess = Remplir_vaisseaux(108);
                    ls = new LightShip(tabRess[0], tabRess[1], tabRess[2], tabRess[3], tabRess[4]);
                    fileVaisseau.Push(ls);
                }
                else
                {
                    tabRess = Remplir_vaisseaux(367);
                    hs = new HeavyShip(tabRess[0], tabRess[1], tabRess[2], tabRess[3], tabRess[4]);
                    fileVaisseau.Push(hs);
                }
            }
        }

        private int[] Remplir_vaisseaux(int reste)
        {
            int rest, i;
            int[] tabRess = new int[5];

            rest = reste;
            for (i = 4; i >= 0; i--)
            {
                if (i >= 1)
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
            Ctri centreTri;
            tabCentreTri = new Ctri[choix*10];
            for(int i = 1; i <= (choix*10); i++)
            {
                if (IsEven(i))
                    centreTri = new Ctri(true);
                else
                    centreTri = new Ctri(false);
                tabCentreTri[i - 1] = centreTri;
            }
        }

        private void Debut_Jeu(int choix)
        {
            Queue<Ship> fileDepart;
            for (int i = 0; i <= choix * 10; i++)
            {
                fileDepart = tabCentreTri[i].getFileDepart;
                do
                {
                    Vider_Vaisseau(fileVaisseau.Peek(),tabCentreTri[i]);
                    fileDepart.Enqueue(fileVaisseau.Peek());
                    tabCentreTri[i].setFileDepart = fileDepart;
                    fileVaisseau.Pop();
                } while (fileVaisseau.Count() == 0);
                if (i != 9)
                    tabCentreTri[i + 1].setFileArriver = fileDepart;
            }
        }

        private void Vider_Vaisseau(Ship vaisseau,Ctri centreTri)
        {
            Stack<Papier> pilePapier;
            Stack<Verre> pileVerre;
            Stack<Plastique> pilePlastique;
            Stack<Feraille> pileFerraille;
            Stack<Terre> pileTerre;
            Papier papier = new Papier(0);
            Verre verre = new Verre(0);
            Plastique plastique = new Plastique(0);
            Feraille feraille = new Feraille(0);
            Terre terre = new Terre(0);
            //Papier
            for (int i = 1; i <= vaisseau.getPapier; i++)
            {
                pilePapier = centreTri.getPilePapier;
                if (isCtriFull(centreTri))
                {
                    pilePapier.Push(papier);
                    centreTri.setPilePapier = pilePapier;
                }
                else
                {
                    do
                    {

                    } while (pilePapier.Count == 0);
                }
            }
            //Verre
            for (int i = 1; i <= vaisseau.getVerre; i++)
            {
                pileVerre = centreTri.getPileVerre;
                if (isCtriFull(centreTri))
                {
                    pileVerre.Push(verre);
                    centreTri.setPileVerre = pileVerre;
                }
                else
                {
                    do
                    {

                    } while (pileVerre.Count == 0);
                }
            }
            //Plastique
            for (int i = 1; i <= vaisseau.getPlastique; i++)
            {
                pilePlastique = centreTri.getPilePlastique;
                if (isCtriFull(centreTri))
                {
                    pilePlastique.Push(plastique);
                    centreTri.setPilePlastique = pilePlastique;
                }
                else
                {
                    do
                    {

                    } while (pilePlastique.Count == 0);
                }
            }
            //Feraille
            for (int i = 1; i <= vaisseau.getFerraille; i++)
            {
                pileFerraille = centreTri.getPileFerraile;
                if (isCtriFull(centreTri))
                {
                    pileFerraille.Push(feraille);
                    centreTri.setPileFerraille = pileFerraille;
                }
                else
                {
                    do
                    {

                    } while (pileFerraille.Count == 0);
                }
            }
            //Terre Contaminé
            for (int i = 1; i <= vaisseau.getTerreConta; i++)
            {
                pileTerre = centreTri.getPileTerre;
                if (isCtriFull(centreTri))
                {
                    pileTerre.Push(terre);
                    centreTri.setPileTerre = pileTerre;
                }
                else
                {
                    do
                    {

                    } while (pileTerre.Count == 0);
                }
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
