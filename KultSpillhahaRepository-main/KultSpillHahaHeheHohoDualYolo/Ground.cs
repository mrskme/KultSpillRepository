using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Ground :Rectangle1
    {
        private bool _immovable;
        public Ground(string name, int width, int height, bool immovable, Color color, int x, int y) : base( name,  width, height, color, x, y)
        {
            _immovable = immovable;
        }
        
    }
}
