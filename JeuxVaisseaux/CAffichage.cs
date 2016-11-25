using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class CAffichage
    {
        CControl CC = new CControl();
        public CAffichage()
        {
            affichage();
        }

        public void affichage()
        {
            int choix = 0;
            Console.Clear();
            Console.CursorLeft = 2;
            Console.CursorTop = 1;
            Console.Write("Application de contrôle du recyclage spatiale, à l'aide de centre de tri.");
            Console.CursorLeft = 2;
            Console.CursorTop = 2;
            Console.Write("Testez l'application avec : ");
            Console.CursorLeft = 2;
            Console.CursorTop = 4;
            Console.Write("1) 10 centre de tris");
            Console.CursorLeft = 2;
            Console.CursorTop = 6;
            Console.Write("2) 20 centre de tris");
            Console.CursorLeft = 2;
            Console.CursorTop = 8;
            Console.Write("3) 30 centre de tris");
            Console.CursorLeft = 2;
            Console.CursorTop = 10;
            Console.Write("4) 40 centre de tris");
            Console.CursorLeft = 2;
            Console.CursorTop = 12;
            Console.Write("5) 50 centre de tris");
            Console.CursorLeft = 2;
            Console.CursorTop = 14;
            Console.Write("0) Quitter");
            Console.CursorLeft = 2;
            Console.CursorTop = 16;
            Console.Write("Option : ");
<<<<<<< HEAD
            choix = Console.ReadLine();
            //try
            //{
            //    if ((Convert.ToInt32(choix) >= 0) || (Convert.ToInt32(choix) <= 5))
            //    {
                    CC.Jouer(Convert.ToInt32(choix));
            //    }
            //    else
            //        affichage();
            //}
            //catch { affichage(); }            
=======
            try
            {
                choix = Convert.ToInt32(Console.ReadLine());
            }
            catch { affichage(); }
            if ((choix >= 0) || (choix <= 5))
            {
                CC.Jouer(choix);
            }
>>>>>>> origin/Alex
        }
    }
}
