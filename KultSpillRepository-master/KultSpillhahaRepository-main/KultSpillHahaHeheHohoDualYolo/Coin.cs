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
        public Coin(Color color, int x, int y, int value, string type) : base("coin",17, 24, color, x,y, true)
        {
            //tell coins og gange med value faktor
            //bronze, sølv og gullcoins
            //revamp coin med _value og få inn oppgraderingene
            //Når man viser coins på skjermen så skjer logikken
        }
        public void DespawnCoin()
        {
            NewRectangle.Visible = false;
            //Form1.form1.Controls.Remove(NewRectangle);
        }
        public bool IsCoinVisible()
        {
            return NewRectangle.Visible;
        }
    }
}
