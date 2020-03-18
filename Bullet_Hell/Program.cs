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

            Enemy Carl = new Enemy(25, 0, @" ___
(._.)
<|>
_/\_");

            int start_position_x = window_x - Carl.enemy_position_x;
            Carl.enemy_position_x = start_position_x;

            Console.WriteLine(Carl);

            Console.ReadLine();
        }
    }
}
