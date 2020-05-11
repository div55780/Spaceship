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

            Task[] tasks = new Task[2];

            Task shipTask = Task.Factory.StartNew(() =>
            {
                InputListener shipListener = new InputListener(spaceship);
                while (shipListener.Listen()) 
                {
                    spaceship.Redraw(spaceship.x, spaceship.y);
                }
            });
            
            Task backgroundTask = Task.Factory.StartNew(async () =>
            {
                while (true)
                {
                    int newX = star.x; 
                    int newY = star.y + 1;
                    if (newX == spaceship.x &&  newY == spaceship.y)
                    {
                        newY += 1;
                    }
                    await Task.Delay(250);
                    if (star.y == screen.height)
                    {
                        newY = 1;
                    }
                    star.Redraw(newX, newY);
                }
            });

            shipTask.Wait();
        }
    }
}
