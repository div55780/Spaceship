using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    class Spaceship : MovableObject
    {
        public Spaceship()
        {
            image = "^";
        }

        public override void Remove()
        {
            Console.SetCursorPosition(oldX, oldY);
            Console.Write(" ");
        }
    }
    
}
