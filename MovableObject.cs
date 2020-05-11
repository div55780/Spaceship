using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Spaseship
{
    abstract class MovableObject
    {
        public string image;

        public int x { get; set; }
        public int y { get; set; }

        public int oldX { get; set; }
        public int oldY { get; set; }

        public virtual void Redraw(int newX, int newY)
        {
            Remove();
            SetPosition(newX, newY);
            Draw();
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(image);
        }

        public virtual void Remove()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }

        public void SetPosition(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }
}
