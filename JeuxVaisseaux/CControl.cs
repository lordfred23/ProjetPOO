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
        CAffichage ca = new CAffichage();
        Ctri[] tabCentreTri;
        //Ship vaisseau;
        Stack<Ship> fileVaisseau = new Stack<Ship>();
        public CControl()
        { }

        public void Jouer()
        {
            int choix = ca.affichage();
            if (choix == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                if (choix != 40)
                {
                    Determiner_NombreVaisseaux(choix);
                    Debut_Jeu(choix);
                }
                else
                {
                    Jouer();
                }
                    
            }
                 
                
           
            
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
            ca.Affichage_Vaisseaux(fileVaisseau);
            Console.ReadLine();
            
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
                    //Utilise fileArriver puisque les prochain centreTri devront faire une deuxieme fonction pour vider
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
                if (IsCTriFull(centreTri))
                {
                    pilePapier.Push(papier);
                    centreTri.setPilePapier = pilePapier;
                }
                else
                {
                    Remplir_Vesseau_Depart(centreTri, pilePapier);
                    i--;
                }
            }
            //Verre
            for (int i = 1; i <= vaisseau.getVerre; i++)
            {
                pileVerre = centreTri.getPileVerre;
                if (IsCTriFull(centreTri))
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
                if (IsCTriFull(centreTri))
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
                if (IsCTriFull(centreTri))
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
                if (IsCTriFull(centreTri))
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

        private void Remplir_Vesseau_Depart(Ctri centreTri, Stack<Papier> pilePapier = null, Stack<Verre> pileVerre = null, Stack<Plastique> pilePlastique = null, Stack<Feraille> pileFeraille = null, Stack<Terre> pileTerre = null)
        {
            //Liste de Stack
            do
            {
                //Chercher la matiere max
                //boucle for avec le poid max du premier vesseau dans depart
                //vider la pile dans le vesseau
            } while (pile.Count == 0);
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
        private bool IsCTriFull(Ctri ct)
        {
            Stack<Papier> pilePapier=ct.getPilePapier;
            Stack<Verre> pileVerre=ct.getPileVerre;
            Stack<Plastique> pilePlastique=ct.getPilePlastique;
            Stack<Feraille> pileFerraille=ct.getPileFerraile;
            Stack<Terre> pileTerre=ct.getPileTerre;


            if (pilePapier.Count() == ct.getTabMax[0])
            {
                return false;
            }
            else
            {
                if (pileVerre.Count() == ct.getTabMax[1])
                {
                    return false;
                }
                else
                {
                    if (pilePlastique.Count() == ct.getTabMax[2])
                    {
                        return false;
                    }
                    else
                    {
                        if (pileFerraille.Count() == ct.getTabMax[3])
                        {
                            return false;
                        }
                        else
                        {
                            if (pileTerre.Count() == ct.getTabMax[4])
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
        }
    }

}
