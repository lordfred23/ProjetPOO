using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class Ctri
    {
        Queue<Ship> fileArriver = new Queue<Ship>();
        Queue<Ship> fileDepart = new Queue<Ship>();
        //int papier, verre, plastique, ferraille, terreConta;
        int[] tabMax = new int[5];
        public Ctri(bool x)
        {
            Determiner_Taille(x);
            Creer_Pile();
        }

        public int[] getTabMax
        { get { return tabMax; } }

        public Queue<Ship> getFileArriver
        { get { return fileArriver; } }

        public Queue<Ship> setFileArriver
        { set { fileArriver = value; } }

        public Queue<Ship> getFileDepart
        { get { return fileDepart; } }

        public Queue<Ship> setFileDepart
        { set { fileDepart = value; } }

        /*public int getPapier
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
        { set { terreConta = value; } }*/

        private void Creer_Pile()
        {
            Papier papier = new Papier(0);
            Verre verre = new Verre(0);
            Plastique plastique = new Plastique(0);
            Feraille feraille = new Feraille(0);
            Terre terre = new Terre(0);
            List<CMatieres> lstMatiere = new List<CMatieres>();
            lstMatiere.Add(papier);
            lstMatiere.Add(verre);
            lstMatiere.Add(plastique);
            lstMatiere.Add(feraille);
            lstMatiere.Add(terre);
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
