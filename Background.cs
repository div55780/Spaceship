using System;
using System.Collections.Generic;
using System.Text;


namespace Spaseship
{
    class Background
    {
        public List<Star> stars = new List<Star>();
        public Screen screen;

        public void Update()
        {
            Random rnd = new Random();

            for (int i = 1; i < 50; i++)
            {
                int x = rnd.Next(0, screen.width);
                int y = rnd.Next(0, screen.height);
                Star s = new Star();
                s.x = x;
                s.y = y;
                stars.Add(s);
            }
        }

    }
}
