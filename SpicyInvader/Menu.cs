using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SpicyInvader
{
    class Menu
    {
        public Menu ()
        {
            string s = "Spicy Invader";
            string t = "]o[ ]o[       ]o[ ]o[";
            int menu = 0;
            bool choixMenu = false;

            // Titre
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 4);
            Console.WriteLine("<xYx>");
            Console.SetCursorPosition((Console.WindowWidth - t.Length) / 2, 2);
            Console.WriteLine(t);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, 6);
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.Gray;

            // Menu
            Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Jouer");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
            Console.WriteLine("Options");

            Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
            Console.WriteLine("Highscore");

            Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
            Console.WriteLine("A propos");

            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
            Console.WriteLine("Quitter");

            Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
            menu = 1;
            do
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (menu == 1) { } /* Ne fait rien, on est déjà en haut du menu */
                        else
                        {
                            menu -= 1;
                            ChangeCouleurMenu(menu);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (menu == 5) { } /* Ne fait rien, on est déjà en bas du menu */
                        else
                        {
                            menu += 1;
                            ChangeCouleurMenu(menu);
                        }
                         break;
                    case ConsoleKey.Enter:
                        choixMenu = true;
                        break;
                    default:
                        break;
                }
            } while (!choixMenu);

            switch (menu)
            {
                case 1:
                    Jouer();
                    break;
                case 2:
                    Options();
                    break;
                case 3:
                    Highscore();
                    break;
                case 4:
                    Apropos();
                    break;
                case 5:
                    Quitter();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Change la couleur du menu en fonction de la séléction
        /// </summary>
        /// <param name="noMenu"></param>
        static void ChangeCouleurMenu(int noMenu)
        {
            switch (noMenu)
            {
                case 1:
                    Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Jouer");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
                    Console.WriteLine("Options");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
                    Console.WriteLine("Options");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
                    Console.WriteLine("Jouer");

                    Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
                    Console.WriteLine("Highscore");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
                    Console.WriteLine("Highscore");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
                    Console.WriteLine("Options");

                    Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
                    Console.WriteLine("A propos");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
                    Console.WriteLine("A propos");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                    Console.WriteLine("Quitter");

                    Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
                    Console.WriteLine("Highscore");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                    Console.WriteLine("Quitter");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
                    Console.WriteLine("A propos");
                    break;
                default:
                    break;
            }
        }

        static void Quitter()
        {
            Environment.Exit(0);
        }

        //remove

        static void Jouer()
        {
            //TimeCtrl shotTimer = new TimeCtrl();
            //Thread shotThread = new Thread(shotTimer.dodo);
            //shotThread.Start();
            //shotTimer.dodo();

            bool endGame = false;

            const string UFO_PLAYER = "<xYx>";
            const string UFO_BONUS = "<=&=>";
            const string UFO_ENEMY3 = "]o[";
            const string UFO_ENEMY2 = "}U{";
            const string UFO_ENEMY1 = "-0-";

            Console.Clear();
            //Affiche sroces et vies
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n   Score : ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0                              ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Lives ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} {0} {0}\n", UFO_PLAYER);

            //Vaisseau joueur
            Ship playerShip = new Ship();
            playerShip.SpawnPlayer();
            //ctrl.Move();

            //Place les ennemis

            UFOBonus ufoBonus = new UFOBonus();
            ufoBonus.Spawn();

            int posX = 10;
            int posY = 6;

            Console.ForegroundColor = ConsoleColor.White;
            Ennemy[,] ufo3 = new Ennemy[5, 11];
            for (int i = 0; i < 5; i++)
            {
                posX = 10;
                for (int j = 0; j < 11; j++)
                {
                    switch (i)
                    {
                        case 0:
                            ufo3[i, j] = new Ennemy(UFO_ENEMY3, posX, posY);
                            break;
                        case 1:
                        case 2:
                            ufo3[i, j] = new Ennemy(UFO_ENEMY2, posX, posY);
                            break;
                        case 3:
                        case 4:
                            ufo3[i, j] = new Ennemy(UFO_ENEMY1, posX, posY);
                            break;
                        default:
                            ufo3[i, j] = new Ennemy("---", posX, posY);
                            break;
                    }
                    posX += 4;
                }
                posY += 1;
            }
            foreach (Ennemy ufo in ufo3)
            {
                ufo.PrintEnnemy();
            }

            do
            {

                posX = 10;
                posY = 6;

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        foreach (Ennemy ufo in ufo3)
                        {
                            ufo.MoveLeft();
                            ufo.PrintEnnemy();
                            Console.Write("  ");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        foreach (Ennemy ufo in ufo3)
                        {
                            ufo.MoveRight();
                            Console.Write("  ");
                            ufo.PrintEnnemy();
                            Console.Write(" ");
                        }
                        break;
                    default:
                        Console.Write("NULL");
                        break;
                }
            } while (!endGame);
        }

            static void Options()
        {
            Console.Clear();
            Console.Write("options");
            Console.Read();
        }

        static void Highscore()
        {
            Console.Clear();
            Console.Write("highscores");
            Console.Read();
        }

        static void Apropos()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - 8) / 2, Console.CursorTop);
            Console.Write("A Propos");
            Console.Write("\n\nJeu créé dans le cadre du projet P_Dev.");
            Console.Read();
        }
    }
}
