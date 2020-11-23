using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace KultSpillHahaHeheHohoDualYolo
{
    class EnemyRectangle : Rectangle1
    {
        private string Direction;
        private int CurrentSpeed;
        private int oldTop;
        private int oldLeft;
        private int RandomDirectionInterval;
        public EnemyRectangle(Color color, int x, int y, string direction, int currentSpeed, int width, int height, int randomDirectionInterval) : base("Enemy", width, height, color, x,  y, false)
        {
            Direction = direction;
            CurrentSpeed = currentSpeed;
            RandomDirectionInterval = randomDirectionInterval;
        }

        public void RandomDirectionIfCollide()
        {
            if (IsObjectColliding(this))
            {
                RandomDirection();

                NewRectangle.Top = oldTop;
                NewRectangle.Left = oldLeft;
            }
        }
        public void MoveEnemyInDirection()
        {

            oldTop = NewRectangle.Top;
            oldLeft = NewRectangle.Left;
                
            if (Direction == "down")
            {
                NewRectangle.Top += CurrentSpeed;
            }
            else if (Direction == "up")
            {
                NewRectangle.Top -= CurrentSpeed;
            }
            else if (Direction == "left")
            {
                NewRectangle.Left -= CurrentSpeed;
            }
            else if (Direction == "right")
            {
                NewRectangle.Left += CurrentSpeed;
            }
            RandomDirectionIfCollide();
        }

        public void RandomDirectionTimer()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, RandomDirectionInterval);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_tick(object sender, EventArgs e)
        {
            RandomDirection();
        }

        private void RandomDirection()
        {
            var random = new Random().Next(0, 4);
            if (random == 0) Direction = "up";
            else if (random == 1) Direction = "down";
            else if (random == 2) Direction = "left";
            else if (random == 3) Direction = "right";
        }
    }
}
