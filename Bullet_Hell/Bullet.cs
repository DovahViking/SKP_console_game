using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;

namespace Bullet_Hell
{
    class Bullet
    {
        public int position_x = 0;
        public int position_y = 0;
        int velocity = 0;
        public string bullet = "*";

        public Bullet(int pos_x, int pos_y, int velocity, string bullet)
        {
            position_x = pos_x;
            position_y = pos_y;
            this.velocity = velocity;
            this.bullet = bullet;
        }

        public void lifetime()
        {
            int time_limit = 1;
            for (int timer = 0; timer < time_limit; timer += 1)
            {
                Thread.Sleep(4000);
                //Destroy bullet
            }
        }

    }
}
