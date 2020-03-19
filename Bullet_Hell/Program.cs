using System;

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
            Enemy Carl = new Enemy(25, 0, @" ___
(._.)
<|>
_/\_");

            Dovah.input();

            int start_position_x = window_x - Carl.enemy_position_x;
            Carl.enemy_position_x = start_position_x;

            //Console.SetCursorPosition((Console.WindowWidth - Carl.enemy.Length) / 2, Console.CursorTop + 1);

            Console.WriteLine(Carl.enemy);


            Console.ReadLine();
        }
    }
}
