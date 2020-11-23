using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Rectangle1 : Collision
    {
        private readonly string _name;
        private readonly int _width;
        private readonly int _height;
        private readonly int _x;
        private readonly int _y;
        public Rectangle1(string name, int width, int height, Color color, int x, int y, bool isImmovable) : base(isImmovable)
        {
            _name = name;
            _width = width;
            _height = height;
            _x = x;
            _y = y;
            NewRectangle.BackColor = color;
            NewRectangle.Name = _name;
            NewRectangle.Width = _width;
            NewRectangle.Height = _height;
            NewRectangle.Location = new Point(_x, _y);
        }
        public void SpawnRectangle(Form formInstance)
        {
            //NewRectangle.Name = _name;
            //NewRectangle.Width = _width;
            //NewRectangle.Height = _height;
            //NewRectangle.Location = new Point(_x,_y);
            formInstance.Controls.Add(NewRectangle);
        }
        public void DespawnRectangle(Form1 formInstance)
        {
            formInstance.Controls.Remove(NewRectangle);
        }
    }
}
