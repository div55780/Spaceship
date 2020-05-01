using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    class Spaceship
    {
        public string image = "^";
        public int x { get; set; }
        public int y { get; set; }


        public void Redraw(int newX, int newY)
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

        public void Remove()
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
