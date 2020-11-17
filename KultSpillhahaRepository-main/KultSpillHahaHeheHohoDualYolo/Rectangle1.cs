using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Rectangle1
    {
        private string _name;
        private int _width;
        private int _height;
        private int _x;
        private int _y;
        private Color _color;
         protected PictureBox newRectangle { get; } = new PictureBox(); 

        public Rectangle1(string name, int width, int height, Color color, int x, int y)
        {
            _name = name;
            _width = width;
            _height = height;
            _x = x;
            _y = y;
            newRectangle.BackColor = color;
            //newRectangle.Width = _width;
            //newRectangle.Height = _height;

        }

        public void SpawnRectangle(Form formInstance/*, int x, int y*//*, Color color*/)
        {
            newRectangle.Name = _name;
            newRectangle.Width = _width;
            newRectangle.Height = _height;
            //newRectangle.BackColor = color;
            newRectangle.Location = new Point(_x,_y);
            formInstance.Controls.Add(newRectangle);
        }
    }
}
