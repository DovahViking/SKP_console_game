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

            Player Dovah = new Player(25, 0, 5, "|__uwu__|");
            Enemy Carl = new Enemy(25, 0, "aaaa");

            Thread enemy_movement = new Thread(Carl.movement); // Thread created cause movement uses thread.sleep()
            Thread Player_Enemy_movements = new Thread(movements); // To update and render enemy and player at the same time /---/ error saying movements() has parameters what the hell??
            enemy_movement.Start();
            Player_Enemy_movements.Start();

            Dovah.input();                                                                                   // TESTS

            Console.Write(Carl.enemy);                                                                       // TESTS

            Console.ReadLine();
        }

        public void movements()
        {
            // PLAN:

            // Console.WriteLine(character);
            // Console.WriteLine(enemy);
            // Clear();

            // So both character and enemy updates at the same time, and is rendered at the same time.
        }
    }
}
