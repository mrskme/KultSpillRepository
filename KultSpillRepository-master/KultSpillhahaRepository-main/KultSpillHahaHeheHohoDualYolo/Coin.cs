﻿using System;
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
        public static readonly Label coinLabel = new Label();
        public Coin( int x, int y) :base("coin",17, 24, Color.Gold, x,y, false)
        {
            coinLabel.Width = 150;
            coinLabel.Height = 50;
            coinLabel.Top = 6;
            coinLabel.Left = 918;
            coinLabel.Text = "Gold: ";
            coinLabel.ForeColor = Color.Gold;
            coinLabel.BackColor = Color.Transparent;
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font font = new Font(fontFamily, 25);
            coinLabel.Font = font;
            //NewRectangle.SendToBack(); ???
        }
        public void MakeCoinInvisible()
        {
            NewRectangle.Visible = false;
        }
        public bool IsCoinVisible()
        {
            return NewRectangle.Visible;
        }
    }
}
