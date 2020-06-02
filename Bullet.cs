using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    class Bullet : MovableObject
    {
        public MovableObject parent;
        public bool isActive;
        public bool isFired;

        public Bullet (MovableObject parent)
        {
            this.parent = parent;
            image = ".";
            isActive = false;
            x = 0;
            y = 0;
        }

        
    }
}
