using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    class Screen
    {
        public int width { 
            get
            {
                return Console.WindowWidth;
            }
        }

        public int height
        {
            get
            {
                return Console.WindowHeight;
            }
        }
    }
}
