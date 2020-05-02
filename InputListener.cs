using System;
using System.Collections.Generic;
using System.Text;

namespace Spaseship
{
    class InputListener
    {
        MovableObject listeningObject;
        
        public InputListener(MovableObject drivableObject)
        {
            listeningObject = drivableObject;
        }
        
        public bool Listen()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                return false;
            }
            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                {
                        //listeningObject.y -= 1;
                        listeningObject.Redraw(listeningObject.x, listeningObject.y - 1);
                        break;
                }
                case ConsoleKey.S:
                {
                        //listeningObject.y += 1;
                        listeningObject.Redraw(listeningObject.x, listeningObject.y + 1);
                        break;
                }
                case ConsoleKey.A:
                {
                        //listeningObject.x -= 1;
                        listeningObject.Redraw(listeningObject.x - 1, listeningObject.y);
                        break;
                }
                case ConsoleKey.D:
                {
                        //listeningObject.x += 1;
                        listeningObject.Redraw(listeningObject.x + 1, listeningObject.y);
                        break;
                }
            }
            return true;
        }
    }
}
