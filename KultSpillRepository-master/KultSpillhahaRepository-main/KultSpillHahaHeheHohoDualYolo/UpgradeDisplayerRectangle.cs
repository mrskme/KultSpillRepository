using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class UpgradeDisplayerRectangle :Rectangle1
    {
        private Color _backColor;
        //private Color _borderColor;
        private int _x;
        private int _y;
        public UpgradeDisplayerRectangle(Color backColor,/* Color borderColor,*/ int x, int y) : base("UpgradeRectangle", 25, 35, backColor, x, y, true)
        {
            _backColor = backColor;
            //_borderColor = borderColor;
            _x = x;
            _y = y;
            NewRectangle.BorderStyle = BorderStyle.FixedSingle;
        }
        public void ColorRectangle()
        {
            NewRectangle.BackColor = Color.Gold;
        }
    }
}
