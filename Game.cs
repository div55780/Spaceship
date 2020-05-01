using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Spaseship
{
    class Game
    {
        public Screen screen;
        public Spaceship spaceship;
        public Star star;
        public void Init()
        {
            screen = new Screen();
            spaceship = new Spaceship();
            spaceship.SetPosition(screen.width / 2, screen.height);

            star = new Star();
            star.SetPosition(screen.width / 2, screen.height / 2);
        }
        public void Start()
        {
            spaceship.Draw();
            star.Draw();

            Task shipTask = Task.Factory.StartNew(() =>
            {
                InputListener shipListener = new InputListener(spaceship);
                shipListener.Listen();
            });
            
            Task backgroundTask = Task.Factory.StartNew(async () =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int newX = star.x; 
                    int newY = star.y + 1;
                    await Task.Delay(100);
                    if (star.y >= screen.height)
                    {
                        star.Remove();
                        star = null;
                    }
                    else
                    {
                        star.Redraw(newX, newY);
                    }
                    
                }
            });
            
            
            backgroundTask.Wait();
            shipTask.Wait();
        }
    }
}
