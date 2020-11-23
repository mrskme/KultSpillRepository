using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Buttons
    {
        Button button = new Button();
        public Player ChosenPlayer = GameLevel._player;
        private int _speedUpgradePrice = 1;

        public Buttons(Point location, int width, int height)
        {
            if (ChosenPlayer.CanPayThePrice(_speedUpgradePrice))
            {
                button.BackColor = Color.FromArgb(18, 191, 2);
                button.Text = $"BUY {_speedUpgradePrice}";
            }
            else
            {
                button.BackColor = Color.Red;
                button.Text = ":(";
            }
            button.Width = width;
            button.Height = height;
            button.Location = location; 
        }

        public void SpawnButton(Form1 formInstance)
        {
            formInstance.Controls.Add(button);
        }

        private void UpdateButton(Form1 formInstance)
        {
            formInstance.Controls.Remove(button);
            formInstance.Controls.Add(button);
        }
        public void ButtonClick()
        {
            button.Click += ButtonOnClick;
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            if (ChosenPlayer.CanPayThePrice(_speedUpgradePrice))
            {
                button.Text = "BUY";
                button.BackColor = Color.FromArgb(18, 191, 2);
                ChosenPlayer.PayThePrice(_speedUpgradePrice);
                ChosenPlayer.SpeedUpgrade();
                if (_speedUpgradePrice == 1) UpgradePanel.speedUpgradeRectangles[0].ColorRectangle();
                else if (_speedUpgradePrice == 2) UpgradePanel.speedUpgradeRectangles[1].ColorRectangle();
                else if (_speedUpgradePrice == 4) UpgradePanel.speedUpgradeRectangles[2].ColorRectangle();
                else if (_speedUpgradePrice == 8) UpgradePanel.speedUpgradeRectangles[3].ColorRectangle();
                else if (_speedUpgradePrice == 16) UpgradePanel.speedUpgradeRectangles[4].ColorRectangle();
                _speedUpgradePrice *= 2;
            }
            else
            {
                button.Text = ":(";
                button.BackColor = Color.Red;
            }
        }
    }
}
