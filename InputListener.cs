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
        
        public void Listen()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                    {
                            listeningObject.Redraw(listeningObject.x, listeningObject.y - 1);
                            break;
                    }
                    case ConsoleKey.S:
                    {
                            listeningObject.Redraw(listeningObject.x, listeningObject.y + 1);
                            break;
                    }
                    case ConsoleKey.A:
                    {
                            listeningObject.Redraw(listeningObject.x - 1, listeningObject.y);
                            break;
                    }
                    case ConsoleKey.D:
                    {
                            listeningObject.Redraw(listeningObject.x + 1, listeningObject.y);
                            break;
                    }
                }
            }
        }
    }
}
