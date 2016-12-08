using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxVaisseaux
{
    class CAffichage
    {
        
        public CAffichage()
        {
            affichage();
        }

        public int affichage()
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
            try { choix = Convert.ToInt32(Console.ReadLine()); }
            catch { affichage(); }
            if ((choix >= 0) && (choix <= 5))
                return choix;
            else
                return 40; 
        }
        public void Affichage_Vaisseaux(Stack<Ship> fileVaisseau)
        {
            Ship vaisseaux;
            int x,i;
            x = 0;
            Console.Clear();

            for(i=1;i<fileVaisseau.Count();i++)
            {
                vaisseaux = fileVaisseau.Pop();
                
                Console.SetCursorPosition(0, x);
                Console.Write(i+": ");
                Console.SetCursorPosition(5, x);
                Console.Write(vaisseaux.getPapier);
                Console.SetCursorPosition(10, x);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(vaisseaux.getVerre);
                Console.SetCursorPosition(15, x);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(vaisseaux.getPlastique);
                Console.SetCursorPosition(20, x);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(vaisseaux.getFerraille);
                Console.SetCursorPosition(25, x);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(vaisseaux.getTerreConta);
                x++;
                Console.ForegroundColor = ConsoleColor.White;


            }
            
        }
    }
}
