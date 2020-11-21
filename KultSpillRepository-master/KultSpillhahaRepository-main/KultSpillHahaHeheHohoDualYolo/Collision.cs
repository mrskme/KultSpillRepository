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
        private readonly List<Collision> allCollideablesList = GameLevel.allCollideables;
        public Collision(bool isImmovable)
        {
            _isImmovable = isImmovable;
        }
        //public bool CheckForCollision(Collision Object2)
        //{
        //    var isColliding = NewRectangle.Bounds.IntersectsWith(Object2.NewRectangle.Bounds);
        //    return isColliding;
        //}
        public bool IsObjectColliding(Collision object1)
        {
            foreach (Collision object2 in allCollideablesList)
            {
                if (object1 != object2)
                {
                    var isCollision = object1.NewRectangle.Bounds.IntersectsWith(object2.NewRectangle.Bounds);
                    if (isCollision) return true;
                }
            }
            return false;
        }

        public bool isObjectColliding(Collision object1, Collision object2)
        {
            if (object1 != object2)
            {
                var isColission = object1.NewRectangle.Bounds.IntersectsWith(object2.NewRectangle.Bounds);
                if (isColission) return true;
            }

            return false;
        }
    }
}
