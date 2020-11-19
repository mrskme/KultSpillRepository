using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Platform :Rectangle1
    {
        public Platform(string name, int width, int height, Color color, int x, int y) : base( name,  width, height, color, x, y, true)
        {
        }
    }
}
