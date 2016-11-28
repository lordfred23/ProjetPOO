using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Ctri
    {
        Stack<Papier> pilePapier;
        Stack<Verre> pileVerre;
        Stack<Plastique> pilePlastique;
        Stack<Feraille> pileFerraille;
        Stack<Terre> pileTerre;


        int[] tabMax = new int[5];
        public Ctri(bool x)
        {
            Determiner_Taille(x);
            Creer_Pile();
        }

        public int[] getTabMax
        { get { return tabMax; } }

        public Stack<Papier> getPilePapier
        { get { return pilePapier; } }
        public Stack<Papier> setPilePapier
        { set {  pilePapier=value; } }
        public Stack<Verre> getPileVerre
        { get{ return pileVerre; } }
        public Stack<Verre> setPileVerre
        { set { pileVerre=value; } }
        public Stack<Plastique> getPilePlastique
        { get { return pilePlastique; } }
        public Stack<Plastique> setPilePlastique
        { set { pilePlastique = value; } }
        public Stack<Feraille> getPileFerraile
        { get { return pileFerraille; } }
        public Stack<Feraille> setPileFerraille
        { set { pileFerraille = value; } }
        public Stack<Terre> getPileTerre
        { get { return pileTerre; } }
        public Stack<Terre> setPileTerre
        { set { pileTerre = value; } }




        private void Creer_Pile()
        {
            Stack<Papier> pilePapier = new Stack<Papier>();
            Stack<Verre> pileVerre = new Stack<Verre>();
            Stack<Plastique> pilePlastique = new Stack<Plastique>();
            Stack<Feraille> pileFerraille = new Stack<Feraille>();
            Stack<Terre> pileTerre = new Stack<Terre>();
            
        }

        private void Determiner_Taille(bool x)
        {
            // Note : le tableaux [0]=Papier [1]=Verre [2]=Plastique [3]=Ferraille [4]=Terre Contaminées
            if(x)
            {
                tabMax[0] =1003;
                tabMax[1] =857;
                tabMax[2] =3456;
                tabMax[3] =457;
                tabMax[4] =639;                
            }
            else
            {
                tabMax[0] = 3067;
                tabMax[1] = 2456;
                tabMax[2] = 561;
                tabMax[3] = 2658;
                tabMax[4] = 8234;
            }
        }
    }
}
