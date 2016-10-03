using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    class Controls
    {
        int i = 30;
        int j = 23;
        int largeur = 7;
        int hauteur = 1;

        public Controls()
        {

        }

        public void Move()
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey(true);
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (i > 0)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i - 1, j);
                            i--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (i < Console.WindowWidth - largeur)
                        {
                            Console.MoveBufferArea(i, j, largeur, hauteur, i + 1, j);
                            i++;
                        }
                        break;
                        // case ConsoleKey.Spacebar:
                        //Tir
                        //   break;

                }
                if (info.Key == ConsoleKey.Escape)

                    break;

            }
        }
    }
}
