using System;
using System.Collections.Generic;
using System.Text;

namespace Bullet_Hell
{
    public class Enemy
    {
        public int enemy_position_x = 25;
        public int enemy_position_y;
        public string enemy = @" ___
(._.)
<|>
_/\_";

        public Enemy(int pos_x, int pos_y, string enemy)
        {
            enemy_position_x = pos_x;
            enemy_position_y = pos_y;
            enemy = this.enemy;
        }

    }
}
