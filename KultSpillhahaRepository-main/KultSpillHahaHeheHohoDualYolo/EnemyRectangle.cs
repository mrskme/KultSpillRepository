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
        private int _speed;
        private string _direction;
        private bool _isColliding;
        public EnemyRectangle(int speed, string direction, Color color, int x, int y) : base("Enemy", 50, 50, color, x,  y)
        {
            _speed = speed;
            _direction = direction;
        }
        public void MoveDirection()
        {
            if (_direction == "down")
            {
                newRectangle.Top += _speed;
            }
            else if (_direction == "up")
            {
                newRectangle.Top -= _speed;
            }
            else if (_direction == "left")
            {
                newRectangle.Left -= _speed;
            }
            else if (_direction == "right")
            {
                newRectangle.Left += _speed;
            }
        }
        public void CheckForCollision(EnemyRectangle enemy2)
        {
            var isColliding = newRectangle.Bounds.IntersectsWith(enemy2.newRectangle.Bounds);
            if (isColliding)
            {
                _direction = null;
            }
        }
        public static void IsEnemyColliding()
        {
            var enemyList = Spawner.EnemyList;

            foreach (EnemyRectangle enemy in enemyList)
            {
                foreach (EnemyRectangle enemy2 in enemyList)
                {
                    if (enemy != enemy2)
                    {
                        enemy.CheckForCollision(enemy2);
                    }
                }
            }
        }
    }
}
