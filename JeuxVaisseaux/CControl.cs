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
        public CControl() { }

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
            Cree_Vaisseaux(choix * 15);
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
            tabCentreTri = new Ctri[4];
            for (int i = 1; i <= (4); i++)
            {
                centreTri = new Ctri(IsEven(i), EstNombrePremier(i), EstMultipleCinq(i));
                tabCentreTri[i - 1] = centreTri;
            }
            Queue<Ship> fileArriver = tabCentreTri[0].getFileArriver;
            int nbVaisseau = fileVaisseau.Count;
            for (int i = 1; i <= nbVaisseau; i++)
            {
                fileArriver.Enqueue(fileVaisseau.Pop());
            }
            tabCentreTri[0].setFileArriver = fileArriver;
        }

        private void Debut_Jeu(int choix)
        {
            Queue<Ship> fileDepart;
            for (int i = 0; i < 4; i++)
            {
                fileDepart = tabCentreTri[i].getFileDepart;
                do
                {
                    Vider_Vaisseau(tabCentreTri[i].getFileArriver.Peek(), tabCentreTri[i]);
                    fileDepart.Enqueue(tabCentreTri[i].getFileArriver.Dequeue());
                    tabCentreTri[i].setFileDepart = fileDepart;
                } while (tabCentreTri[i].getFileArriver.Count != 0);
                if (i != (4) - 1)
                    tabCentreTri[i + 1].setFileArriver = fileDepart;
            }
            for (int i = 0; i < 4; i++)
            {
                ca.Afficher_Final(tabCentreTri[i], i + 1);
            }
            Console.ReadLine();

        }

        private void Vider_Vaisseau(Ship vaisseau, Ctri centreTri)
        {
            Queue<Ship> fileDepart = centreTri.getFileDepart;
            //Papier
            //--------------------------------------------------------------
            viderPapier(centreTri, vaisseau, fileDepart);
            //Verre
            //--------------------------------------------------------------            
            viderVerre(centreTri,vaisseau,fileDepart);
            //Plastique
            //--------------------------------------------------------------
            viderPlastique(centreTri, vaisseau, fileDepart);
            //Feraille
            //-------------------------------------------------------------
            viderFeraille(centreTri, vaisseau, fileDepart);
            //Terre Contaminé
            //------------------------------------------------------------
            viderTerre(centreTri, vaisseau, fileDepart);
            //vider vaisseau
            centreTri.setFileDepart = fileDepart;
        }
        private void viderPapier(Ctri centreTri,Ship vaisseau,Queue<Ship>fileDepart)
        {
            if (centreTri.getTabMax[0] != 0)
            {
                Stack<Papier> pilePapier;
                Papier papier = new Papier(1);
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
                        do
                        {
                            Ship ship = fileDepart.Dequeue();
                            for (int u = 0; u <= ship.getPoidMax; u++)
                            {
                                if ((pilePapier.Count != 0) && (u < ship.getPoidMax))
                                    pilePapier.Pop();
                                else
                                {
                                    ship.setPapier = u;
                                    u = 400;
                                }
                            }
                            fileDepart.Enqueue(ship);
                        } while (pilePapier.Count <= 0);
                        i--;
                    }
                }
                vaisseau.setPapier = 0;
            }
        }

        private void viderVerre(Ctri centreTri, Ship vaisseau,Queue<Ship> fileDepart)
        {
            Stack<Verre> pileVerre;
            Verre verre = new Verre(1);

            if (centreTri.getTabMax[1] != 0)
            {
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
                            Ship ship = fileDepart.Dequeue();
                            for (int u = 0; u <= ship.getPoidMax; u++)
                            {
                                if ((pileVerre.Count != 0) && (u < ship.getPoidMax))
                                    pileVerre.Pop();
                                else
                                {
                                    ship.setVerre = u;
                                    u = 400;
                                }
                            }
                            fileDepart.Enqueue(ship);
                        } while (pileVerre.Count <= 0);
                        i--;
                    }
                }
                vaisseau.setVerre = 0;
            }
        }

        private void viderPlastique(Ctri centreTri, Ship vaisseau, Queue<Ship> fileDepart)
        {
            Stack<Plastique> pilePlastique;
            Plastique plastique = new Plastique(0);
            if (centreTri.getTabMax[2] != 0)
            {
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
                            Ship ship = fileDepart.Dequeue();
                            for (int u = 0; u <= ship.getPoidMax; u++)
                            {
                                if ((pilePlastique.Count != 0) && (u < ship.getPoidMax))
                                    pilePlastique.Pop();
                                else
                                {
                                    ship.setPlasique = u;
                                    u = 400;
                                }
                            }
                            fileDepart.Enqueue(ship);
                        } while (pilePlastique.Count == 0);
                        i--;
                    }
                }
                vaisseau.setPlasique = 0;
            }
        }

        private void viderFeraille(Ctri centreTri, Ship vaisseau, Queue<Ship> fileDepart)
        {
            Stack<Feraille> pileFerraille;
            Feraille feraille = new Feraille(0);
            if (centreTri.getTabMax[3] != 0)
            {
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
                            Ship ship = fileDepart.Dequeue();
                            for (int u = 0; u <= ship.getPoidMax; u++)
                            {
                                if ((pileFerraille.Count != 0) && (u < ship.getPoidMax))
                                    pileFerraille.Pop();
                                else
                                {
                                    ship.setFerraille = u;
                                    u = 400;
                                }
                            }
                            fileDepart.Enqueue(ship);
                        } while (pileFerraille.Count == 0);
                        i--;
                    }
                }
                vaisseau.setFerraille = 0;
            }
        }

        private void viderTerre(Ctri centreTri, Ship vaisseau, Queue<Ship> fileDepart)
        {
            Stack<Terre> pileTerre;
            Terre terre = new Terre(0);
            if (centreTri.getTabMax[4] != 0)
            {
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
                            Ship ship = fileDepart.Dequeue();
                            for (int u = 0; u <= ship.getPoidMax; u++)
                            {
                                if ((pileTerre.Count != 0) && (u < ship.getPoidMax))
                                    pileTerre.Pop();
                                else
                                {
                                    ship.setTerreConta = u;
                                    u = 400;
                                }
                            }
                            fileDepart.Enqueue(ship);
                        } while (pileTerre.Count == 0);
                        i--;
                    }
                }
                vaisseau.setTerreConta = 0;
            }
        }

        private bool IsEven(int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
        public bool EstNombrePremier(double n)
        {

            int i;
            int racine;
            bool fini;
            decimal debRacine = Convert.ToInt32(Math.Sqrt(n));
            racine = Convert.ToInt32(Math.Truncate(debRacine));
            fini = false;
            i = 3;
            if (n < 2) { fini = true; }
            else if (n != 2)
            {
                if (n % 2 == 0)
                {
                    fini = true;
                }
                else
                {
                    while ((!fini) && (i <= racine))
                    {
                        if (n % i == 0) { fini = true; }
                        else { i = i + 2; }

                    }

                }

            }
            return (!fini);
        }
        private bool EstMultipleCinq(int i)
        {
            if (i % 5 == 0)
                return true;
            else
                return false;



        }
        private bool IsCTriFull(Ctri ct)
        {
            Stack<Papier> pilePapier = ct.getPilePapier;
            Stack<Verre> pileVerre = ct.getPileVerre;
            Stack<Plastique> pilePlastique = ct.getPilePlastique;
            Stack<Feraille> pileFerraille = ct.getPileFerraile;
            Stack<Terre> pileTerre = ct.getPileTerre;


            if (pilePapier.Count == ct.getTabMax[0])
            {
                return false;
            }
            else
            {
                if (pileVerre.Count == ct.getTabMax[1])
                {
                    return false;
                }
                else
                {
                    if (pilePlastique.Count == ct.getTabMax[2])
                    {
                        return false;
                    }
                    else
                    {
                        if (pileFerraille.Count == ct.getTabMax[3])
                        {
                            return false;
                        }
                        else
                        {
                            if (pileTerre.Count == ct.getTabMax[4])
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
