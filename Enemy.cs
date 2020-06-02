using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    class Enemy : MovableObject
    {
        public List<Bullet> bullets = new List<Bullet>();
        public int activeBulletIndex = 0;

        public Enemy()
        {
            x = 10;
            y = 1;
            image = "o";
            for (int i = 0; i < 100; i++)
            {
                Bullet b = new Bullet(this);
                bullets.Add(b);
            }
        }

    }
}
