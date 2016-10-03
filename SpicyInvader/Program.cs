using System;

namespace SpicyInvader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taille de la fenêtre et bloquer la redimension
            Console.SetWindowSize(68, 30);
            Console.SetBufferSize(68, 30);

            //Cacher le curseur
            Console.CursorVisible = false;

            //Appel de la classe menu
            Menu mainMenu = new Menu();
            mainMenu.InitMenu(1);//initialise le tableau avec le menu n°1 sélectionné

            Console.ReadLine();
        }
    }
}
