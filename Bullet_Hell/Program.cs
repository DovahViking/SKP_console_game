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

            Console.Write(Dovah);                                                                            // TESTS

            Dovah.input();                                                                                   // TESTS

            int start_position_x = window_x - Carl.enemy_position_x;                                         // TESTS
            Carl.enemy_position_x = start_position_x;                                                        // TESTS

            Console.SetCursorPosition((window_x - Carl.enemy.Length) / 2, Console.CursorTop + 1); // TESTS

            // Write function that updates "SetCursorPosition" for more lines than just one.
            // One Func that deals with SetCursorPosition for each Player, Enemy and Bullet

            Console.Write(@" ___
(._.)
<|>
_/\_");                                                                       // TESTS


            Console.ReadLine();
        }
    }
}
