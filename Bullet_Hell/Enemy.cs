using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Bullet_Hell
{
    public class Enemy
    {
        public int enemy_position_x = 25;
        public int enemy_position_y = 3;
        public string enemy = "Imperial_scum";

        public Enemy(int pos_x, int pos_y, string enemy)
        {
            enemy_position_x = pos_x;
            enemy_position_y = pos_y;
            this.enemy = enemy;
        }

        // position(x, y)
        //public KeyValuePair<int, int> position(int x, int y) // TEST // ----- Not in use yet, may never be -----
        //{
        //    x = enemy_position_x;
        //    y = enemy_position_y;

        //    return new KeyValuePair<int, int>(x, y);
        //}

        public void movement() // TEST
        {
            while (true)
            {
                Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_x, Console.CursorTop = enemy_position_y); // Sets the position for the console writer (int left, int top)
                Thread.Sleep(3000);
                enemy_position_x += 5;
                Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_x, Console.CursorTop = enemy_position_y);
                enemy_position_y += 2;
                Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_y, Console.CursorTop = enemy_position_y);
                Thread.Sleep(2000);
                enemy_position_x -= 8;
                Console.SetCursorPosition((25 - enemy.Length) / 2 + enemy_position_x, Console.CursorTop = enemy_position_y);
                Thread.Sleep(1000);
            }
        }
    }
}
