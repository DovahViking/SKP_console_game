using System;
using System.Collections.Generic;
using System.Text;

namespace Bullet_Hell
{
    class Bullet
    {
        int position_x = 0;
        int position_y = 0;
        int velocity = 0;
        string bullet = "*";

        public Bullet(int pos_x, int pos_y, int velocity, string bullet)
        {
            position_x = pos_x;
            position_y = pos_y;
            this.velocity = velocity;
            this.bullet = bullet;
        }
    }
}
