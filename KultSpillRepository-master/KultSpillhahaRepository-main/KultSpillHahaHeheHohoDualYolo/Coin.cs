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
        private int _coinCount;
        public static readonly Label coinLabel = new Label();
        public Coin(int width, int height, int x, int y) :base("coin",width, height, Color.Gold, x,y, false)
        {
            //player skal ha coin count (variabel og coin grab)
            coinLabel.Width = 50;
            coinLabel.Height = 15;
            coinLabel.Top = 30;
            coinLabel.Left = 100;
            coinLabel.Text = "Gold: ";
            coinLabel.ForeColor = Color.Gold;
            coinLabel.BackColor = Color.CornflowerBlue;
        }

        public void CoinGrab()
        {
            if (IsObjectColliding(this) && NewRectangle.Visible)
            {
                _coinCount++;
                NewRectangle.Visible = false;
                UpdateCoinLabel();
            }
        }

        public void UpdateCoinLabel()
        {
            coinLabel.Text = $"Gold: {_coinCount}";
        }

    }
}
