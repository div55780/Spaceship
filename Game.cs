using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spaseship
{
    class Game
    {
        public Screen screen;
        public Spaceship spaceship;
        public object locker;
        public Background bg;

        public void Init()
        {
            screen = new Screen();
            spaceship = new Spaceship();
            spaceship.SetPosition(screen.width / 2, screen.height);
            bg = new Background();
            bg.screen = screen;
        }
        public void Start()
        {
            spaceship.Draw();
            bg.Update();
            locker = new object();
            Task[] tasks = new Task[2];

            Task shipTask = Task.Factory.StartNew(() =>
            {
                InputListener shipListener = new InputListener(spaceship);
                while (shipListener.Listen()) 
                {
                    lock (locker)
                    {
                        spaceship.Redraw(spaceship.x, spaceship.y);
                    }
                    
                }
            });
            
            Task backgroundTask = Task.Factory.StartNew(async () =>
            {
                Random rnd = new Random();
                while (true)
                {
                    foreach (Star star in bg.stars)
                    {
                        int newX = star.x;
                        int newY = star.y + 1;
                        if (newX == spaceship.x && newY == spaceship.y)
                        {
                            newY += 1;
                        }
                        
                        if (star.y == screen.height)
                        {
                            newX = rnd.Next(bg.screen.width);
                            newY = 2;
                        }
                        lock (locker)
                        {
                            star.Redraw(newX, newY);
                        }
                        
                    }
                    await Task.Delay(150);
                }
            });
            shipTask.Wait();
        }
    }
}
