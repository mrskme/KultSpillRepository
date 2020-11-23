using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Coin : Rectangle1
    {
        public Coin( int x, int y) :base("coin",17, 24, Color.Gold, x,y, true)
        {
        }
        public void DespawnCoin(Form1 formInstance)
        {
            NewRectangle.Visible = false;
            formInstance.Controls.Remove(NewRectangle);
        }
        public bool IsCoinVisible()
        {
            return NewRectangle.Visible;
        }
    }
}
