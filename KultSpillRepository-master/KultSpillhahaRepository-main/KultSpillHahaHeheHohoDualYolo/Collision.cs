using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Collision
    {
        private bool _isImmovable;
        protected PictureBox NewRectangle { get; } = new PictureBox();
        private readonly List<Collision> allObjectsList = Spawner.allObjects;
        public Collision(bool isImmovable)
        {
            _isImmovable = isImmovable;
        }
        public bool CheckForCollision(Collision Object2)
        {
            var isColliding = NewRectangle.Bounds.IntersectsWith(Object2.NewRectangle.Bounds);
            return isColliding;
        }
        public bool IsObjectColliding(Collision object1)
        {
            foreach (Collision object2 in allObjectsList)
            {
                if (object1 != object2)
                {
                    var isCollision = object1.CheckForCollision(object2);
                    if (isCollision) return true;
                }
            }
            return false;
        }
    }
}
