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
            //bronze, sølv og gullcoins?
        }
        public void DespawnCoin()
        {
            NewRectangle.Visible = false;
            Form1.form1.Controls.Remove(NewRectangle);
        }
        public bool IsCoinVisible()
        {
            return NewRectangle.Visible;
        }
    }
}
