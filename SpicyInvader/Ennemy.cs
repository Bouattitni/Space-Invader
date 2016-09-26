using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyInvader
{
    class Ennemy
    {
        private string skin;
        private int posX;
        private int posY;

        // Constructor
        public Ennemy(string skin, int posX, int posY)
        {
            this.skin = skin;
            this.posX = posX;
            this.posY = posY;
        }

        // Print ennemy
        public void PrintEnnemy()
        {
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(skin);
        }

        // Move left
        public void MoveLeft()
        {
            posX -= 2;
        }

        // Move right
        public void MoveRight()
        {
            posX += 2;
        }
    }
}
