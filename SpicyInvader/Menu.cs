/// ETML
/// Auteur : Maude
/// Date : 29.07.2016
/// Description : Menu du spicy invader
/// Change Log :
///     Date : 03.10.2016
///         par : Loïc
///         Détail : Ajour de commentaire, modifications mineures, cacher l'écriture de l'utilisateur, retour au menu

using System;

namespace SpicyInvader
{
    class Menu
    {
        //Couleur du texte
        static ConsoleColor basicColor = ConsoleColor.Gray;//couleur de base
        static ConsoleColor selectColor = ConsoleColor.Yellow;//couleur de sélection du menu
        static ConsoleColor hideColor = ConsoleColor.Black;//couleur pour cacher l'écriture de l'utilisateur
        static ConsoleColor titleColor = ConsoleColor.Green;//couleur du titre
        static ConsoleColor decoTitleColor = ConsoleColor.Magenta;//Couleur des décoration du titre


        /// <summary>initialise le menu</summary>
        /// <param name="noMenu">Numéro du menu</param>
        public void InitMenu(int noMenu)
        {
            string title = "Spicy Invader";//Titre
            string titleDeco1 = "]o[ ]o[       ]o[ ]o[";//décoration du titre
            string titleDeco2 = "<xYx>";//décoration du titre           
            bool chooseMenu = false;//True quand l'utilisateur a séléctionner un menu

            //Effacer la Console si on veut récrire le menu
            Console.Clear();

            // Titre
            Console.ForegroundColor = decoTitleColor;
            Console.SetCursorPosition((Console.WindowWidth - titleDeco2.Length) / 2, 4);
            Console.WriteLine(titleDeco2);
            Console.SetCursorPosition((Console.WindowWidth - titleDeco1.Length) / 2, 2);
            Console.WriteLine(titleDeco1);
            Console.ForegroundColor = titleColor;
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, 6);
            Console.WriteLine(title);
            Console.ForegroundColor = basicColor;

            // Menu
            Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
            Console.WriteLine("Jouer");
            Console.ForegroundColor = basicColor;

            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
            Console.WriteLine("Options");

            Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
            Console.WriteLine("Highscore");

            Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
            Console.WriteLine("A propos");

            Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
            Console.WriteLine("Quitter");

            //Applique la couleur au menu sélectionner
            ChangeCouleurMenu(noMenu);

            //Met le curseur en haut à gauche et change la couleur en noir afin de ne pas voir l'écriture de l'utilisateur
            Console.ForegroundColor = hideColor;
            Console.SetCursorPosition(0,0);

            do
            {
                //Permet de déplacer sur le menu
                switch (Console.ReadKey().Key)
                {
                    //À l'appui de la touche flèche du haut
                    case ConsoleKey.UpArrow:
                        if (noMenu == 1)
                        {
                            noMenu = 5;
                            ChangeCouleurMenu(noMenu);//change la couleur du menu
                        } 
                        else
                        {
                            noMenu--;
                            ChangeCouleurMenu(noMenu);//change la couleur du menu
                        }
                        break;
                    //À l'appui de la touche flèche du bas
                    case ConsoleKey.DownArrow:
                        if (noMenu == 5)
                        {
                            noMenu = 1;
                            ChangeCouleurMenu(noMenu);//change la couleur du menu
                        }
                        else
                        {
                            noMenu++;
                            ChangeCouleurMenu(noMenu);
                        }
                        break;
                    //À l'appui de la touche enter
                    case ConsoleKey.Enter:
                        chooseMenu = true;
                        break;
                    //Autre touche
                    default:
                        //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en haut à gauche noir sur noir pour cacher
                        Console.SetCursorPosition(0, 0);
                        Console.ForegroundColor = hideColor;
                        Console.Write("");
                        break;
                }
            } while (!chooseMenu);//tant qu'il est à false

            //Méthode à appeller à l'entrée d'un menu
            switch (noMenu)
            {
                case 1:
                    Play();
                    //Réaffiche le menu principal
                    InitMenu(1);
                    break;
                case 2:
                    Options();
                    //Réaffiche le menu principal
                    InitMenu(2);
                    break;
                case 3:
                    Highscore();
                    //Réaffiche le menu principal
                    InitMenu(3);
                    break;
                case 4:
                    About();
                    //Réaffiche le menu principal
                    InitMenu(4);
                    break;
                case 5:
                    Exit();
                    //Réaffiche le menu principal
                    InitMenu(5);
                    break;
                default:
                    break;
            }
          
        }

        /// <summary>
        /// Change la couleur du menu en fonction de la séléction
        /// </summary>
        /// <param name="noMenu">Numéro du menu</param>
        static void ChangeCouleurMenu(int noMenu)
        {
            switch (noMenu)
            {
                case 1:
                    Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
                    Console.ForegroundColor = selectColor;
                    Console.WriteLine("Jouer");

                    Console.ForegroundColor = basicColor;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
                    Console.WriteLine("Options");

                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                    Console.WriteLine("Quitter");

                    //Remet le curseur en haut à gauche
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = hideColor;
                    break;
                case 2:
                    Console.ForegroundColor = selectColor;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
                    Console.WriteLine("Options");

                    Console.ForegroundColor = basicColor;
                    Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
                    Console.WriteLine("Jouer");

                    Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
                    Console.WriteLine("Highscore");

                    //Remet le curseur en haut à gauche
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = hideColor;
                    break;
                case 3:
                    Console.ForegroundColor = selectColor;
                    Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
                    Console.WriteLine("Highscore");
                    
                    Console.ForegroundColor = basicColor;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 15);
                    Console.WriteLine("Options");

                    Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
                    Console.WriteLine("A propos");

                    //Remet le curseur en haut à gauche
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = hideColor;
                    break;
                case 4:
                    Console.ForegroundColor = selectColor;
                    Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
                    Console.WriteLine("A propos");

                    Console.ForegroundColor = basicColor;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                    Console.WriteLine("Quitter");

                    Console.SetCursorPosition((Console.WindowWidth - 9) / 2, 18);
                    Console.WriteLine("Highscore");

                    //Remet le curseur en haut à gauche
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = hideColor;
                    break;
                case 5:
                    Console.ForegroundColor = selectColor;
                    Console.SetCursorPosition((Console.WindowWidth - 7) / 2, 24);
                    Console.WriteLine("Quitter");

                    Console.ForegroundColor = basicColor;
                    Console.SetCursorPosition((Console.WindowWidth - 8) / 2, 21);
                    Console.WriteLine("A propos");

                    Console.SetCursorPosition((Console.WindowWidth - 5) / 2, 12);
                    Console.WriteLine("Jouer");

                    //Remet le curseur en haut à gauche
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = hideColor;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Menu qui quitte l'application
        /// </summary>
        static void Exit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Menu jouer
        /// </summary>
        static void Play()
        {
            bool endGame = false;

            const string UFO_PLAYER = "<xYx>";
            const string UFO_BONUS = "<=&=>";
            const string UFO_ENEMY3 = "]o[";
            const string UFO_ENEMY2 = "}U{";
            const string UFO_ENEMY1 = "-0-";

            Console.Clear();
            Console.CursorVisible = false;
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

        /// <summary>
        /// Menu options
        /// </summary>
        static void Options()
        {
            bool quitMenu = false;//True quand l'utilisateur a quitté le menu

            Console.Clear();
            Console.ForegroundColor = basicColor;
            Console.Write("options");

            //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en bas à gauche noir sur noir pour cacher
            Console.SetCursorPosition(0, Console.WindowHeight -1);
            Console.ForegroundColor = hideColor;

            do
            {
                switch (Console.ReadKey().Key)
                {
                    //À l'appui de la touche flèche du haut
                    case ConsoleKey.Backspace:
                        quitMenu = true;
                        break;
                    //Autre touche
                    default:
                        //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en bas à gauche noir sur noir pour cacher
                        Console.SetCursorPosition(0, Console.WindowHeight - 1);
                        
                        Console.Write("");
                        break;
                }
            } while (!quitMenu);//tant qu'il est à false
           
        }

        /// <summary>
        /// Menu des meilleurs scores
        /// </summary>
        static void Highscore()
        {
            bool quitMenu = false;//True quand l'utilisateur a quitté le menu

            Console.Clear();
            Console.ForegroundColor = basicColor;
            Console.Write("highscores");

            //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en bas à gauche noir sur noir pour cacher
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ForegroundColor = hideColor;

            do
            {
                switch (Console.ReadKey().Key)
                {
                    //À l'appui de la touche flèche du haut
                    case ConsoleKey.Backspace:
                        quitMenu = true;
                        break;
                    //Autre touche
                    default:
                        //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en bas à gauche noir sur noir pour cacher
                        Console.SetCursorPosition(0, Console.WindowHeight - 1);

                        Console.Write("");
                        break;
                }
            } while (!quitMenu);//tant qu'il est à false
        }

        /// <summary>
        /// Menu à propos
        /// </summary>
        static void About()
        {
            bool quitMenu = false;//True quand l'utilisateur a quitté le menu

            Console.Clear();
            Console.ForegroundColor = basicColor;
            Console.SetCursorPosition((Console.WindowWidth - 8) / 2, Console.CursorTop);
            Console.Write("A Propos");
            Console.Write("\n\nJeu créé dans le cadre du projet P_Dev.");

            //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en bas à gauche noir sur noir pour cacher
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Black;

            do
            {
                switch (Console.ReadKey().Key)
                {
                    //À l'appui de la touche flèche du haut
                    case ConsoleKey.Backspace:
                        quitMenu = true;
                        break;
                    //Autre touche
                    default:
                        //Si l'utilisateur entre autre chose que les touches pour se déplacer, il le fait écrir en bas à gauche noir sur noir pour cacher
                        Console.SetCursorPosition(0, Console.WindowHeight - 1);

                        Console.Write("");
                        break;
                }
            } while (!quitMenu);//tant qu'il est à false
        }
    }
}
