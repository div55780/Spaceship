﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    abstract class MovableObject
    {
        public string image;
        public int x { get; set; }
        public int y { get; set; }
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