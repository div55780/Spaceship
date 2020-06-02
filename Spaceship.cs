using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spaseship
{
    class Spaceship : MovableObject
    {
        public List<Bullet> bullets = new List<Bullet>();
        public int activeBulletIndex = 0;

        public Spaceship()
        {
            image = "^";
            for (int i = 0; i < 100; i++)
            {
                Bullet b = new Bullet(this);
                bullets.Add(b);
            }
        }

        public override void Remove()
        {
            Console.SetCursorPosition(oldX, oldY);
            Console.Write(" ");
        }

        public override void Shoot()
        {
            Bullet activeBullet = bullets.ElementAt(activeBulletIndex);
            activeBullet.isActive = true;
            activeBullet.isFired = true;
            activeBullet.x = this.x - 1;
            activeBullet.y = this.y;
            activeBulletIndex += 1;
        }
    }
    
}
