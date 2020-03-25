using System;
using System.Threading;

namespace Bullet_Hell
{
    class Program
    {
        static void Main(string[] args)
        {
            int window_x = 50;
            int window_y = 20;
            Console.SetWindowSize(window_x, window_y);

            Player Dovah = new Player(25, 18, 5, "[Player]"); // TEST
            Enemy Imperial_scum = new Enemy(25, 0, "[Enemy]"); // TEST

            Thread enemy_movement = new Thread(Imperial_scum.movement); // Thread created cause movement uses thread.sleep()
            Thread Player_Enemy_movements = new Thread(()=>movements(Dovah, Imperial_scum)); // To update and render enemy and player at the same time
            enemy_movement.Start();
            Player_Enemy_movements.Start();

            Dovah.input(); // Player movement

            Console.ReadLine();
        }

        public static void movements(Player Dovah, Enemy Imperial_scum) // /---/ Without the trigger and movements() movement would be fine, but would only show for the player and not the enemy
        {

            ConsoleKeyInfo cki;
            while (true)
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.W || cki.Key == ConsoleKey.A || cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.D || 
                    cki.Key == ConsoleKey.UpArrow || cki.Key == ConsoleKey.LeftArrow || cki.Key == ConsoleKey.DownArrow || cki.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine(Dovah.character); // input every 2nd ReadKey()?.. 
                    Console.WriteLine(Imperial_scum.enemy); // input every 2nd ReadKey()?.. /--/ follows player's y_axis?? /--/ completely stuck at player's x_axis??
                }
            }
            // So both character and enemy updates at the same time, and is rendered at the same time
        }
    }
}
