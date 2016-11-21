using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Ctri
    {
        int papier, verre, plastique, ferraille, terreConta;
        int[] tabMax = new int[4];
        public Ctri(bool x)
        {

        }

        public int getPapier
        { get{ return papier; } }
        public int setPapier
        { set { papier = value; }  }

        public int getVerre
        { get { return verre; } }
        public int setVerre
        { set { verre = value; } }

        public int getPlastique
        { get { return plastique; } }
        public int setPlastique
        { set { plastique = value; } }

        public int getFerraille
        { get { return ferraille; } }
        public int setFerraille
        { set { ferraille = value; } }

        public int getTerreConta
        { get { return terreConta; } }
        public int setTerreConta
        { set { terreConta = value; } }


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
