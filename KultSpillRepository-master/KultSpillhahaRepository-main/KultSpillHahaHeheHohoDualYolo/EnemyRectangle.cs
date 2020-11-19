using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KultSpillHahaHeheHohoDualYolo
{
    class EnemyRectangle : Rectangle1
    {
        public string Direction;
        public int CurrentSpeed;
        private int oldTop;
        private int oldLeft;
        public EnemyRectangle(Color color, int x, int y, string direction, int currentSpeed) : base("Enemy", 50, 50, color, x,  y, false/*, direction*//*,"kake" , currentSpeed*/)
        {
            Direction = direction;
            CurrentSpeed = currentSpeed;
        }

        public void RandomDirectionIfCollide()
        {
            if (IsObjectColliding(this)) 
            {
                var random = new Random().Next(0,4);
                if (random == 0) Direction = "up";
                if (random == 1) Direction = "down";
                if (random == 2) Direction = "left";
                if (random == 3) Direction = "right";
                
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
    }
}
