using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bullet_Hell
{
    public class Enemy
    {
        public int enemy_position_x = 25;
        public int enemy_position_y;
        public string enemy = ">:c";

        public Enemy(int pos_x, int pos_y, string enemy)
        {
            enemy_position_x = pos_x;
            enemy_position_y = pos_y;
            enemy = this.enemy;
        }

        // position(x, y)
        public KeyValuePair<int, int> position(int x, int y) // TEST
        {
            x = enemy_position_x;
            y = enemy_position_y;

            return new KeyValuePair<int, int>(x, y);
        }

        public void movement() // TEST
        {
            Console.Clear();
            Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_x, Console.CursorTop + 1); // Sets the position for the console writer
            Console.WriteLine(enemy);                                                                     // Prints out the enemy string at the position given above
            Thread.Sleep(3000);                                                                           // Wait for 3 seconds
            enemy_position_x += 5;                                                                        // Changes the position on the x axis
            Console.Clear();                                                                              // Clears the console, so things aren't "repeating themselves"
            Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_x, Console.CursorTop + 1);
            Console.WriteLine(enemy);
            enemy_position_y += 2;
            Console.Clear();
            Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_y, Console.CursorTop + 1);
            Console.WriteLine(enemy);
            Thread.Sleep(2000);
            enemy_position_x -= 8;
            Console.Clear();
            Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_x, Console.CursorTop + 1);
            Console.WriteLine(enemy);
        }
    }
}
