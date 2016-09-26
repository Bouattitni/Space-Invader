using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    class Ship
    {
        int X = 30;
        int Y = 21;
        const int shipLine = 21;
        string ship = "<xYx>";

        public Ship()
        {
            int X = 30;
            int Y = 21;
            const int shipLine = 21;
            string ship = "<xYx>";
        }
        public void SpawnPlayer()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(ship);
        }
        public void rightMove()
        {
            if (X < Console.WindowWidth - 5)
            {
                //valeur X,Y de depart,Taille du vaisseau,hauteur du vaisseau, déplacementX,Y
                Console.MoveBufferArea(X, Y, 5, 1, X + 1, shipLine);
                X++;
            }
        }
        public void leftMove()
        {
            if (X > 0)
            {
                //valeur X,Y de depart,Taille du vaisseau,hauteur du vaisseau, déplacementX,Y
                Console.MoveBufferArea(X, Y, 5, 1, X - 1, shipLine);
                X--;
            }
        }
    }
}
