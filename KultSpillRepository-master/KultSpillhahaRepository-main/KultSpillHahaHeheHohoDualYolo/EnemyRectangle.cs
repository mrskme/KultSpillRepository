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
        public EnemyRectangle(Color color, int x, int y, string direction, int currentSpeed) : base("Enemy", 50, 50, color, x,  y, false/*, direction*//*,"kake" , currentSpeed*/)
        {
            Direction = direction;
            CurrentSpeed = currentSpeed;
        }
        public void MoveEnemyInDirection()
        {
            if (!IsObjectColliding(this)) 
            {
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
                else if (Direction == "backAndForth")
                {
                //MoveEverything back and forth
                //if (newRectangle.position == punkt1) _direction == "høyre";
                //if (newRectangle.position == punkt2) _direction == "venstre";
                }
            }
        }
    }
}
