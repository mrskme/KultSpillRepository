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
        private static int _speedUpgradePrice = 2;
        private int _sizeUpgradePrice = 2;
        private int _coinFindUpgradePrice = 2;
        private int _coinValueUpgradePrice = 2;

        public Buttons(Point location, int width, int height, string text, Font font) 
        {
            button.BackColor = Color.FromArgb(18, 191, 2);
            button.Text = text;
            button.Font = font;
            button.Width = width;
            button.Height = height;
            button.Location = location; 
        }
        public void SpawnButton( )
        {
            Form1.form1.Controls.Add(button);
        }
        public void DespawnButton( )
        {
            Form1.form1.Controls.Remove(button);
        }
        //private void UpdateButton(Form1 formInstance)
        //{
        //    formInstance.Controls.Remove(button);
        //    formInstance.Controls.Add(button);
        //}
        public void SpeedUpgradeOnClick()
        {
            button.Click += SpeedUpgradeFunctionality;
        }
        public void sizeUpgradeUpgradeOnClick()
        {
            button.Click += SizeUpgradeFunctionality;
        }
        public void CoinFindUpgradeOnClick()
        {
            button.Click += CoinFindUpgradeFunctionality;
        }

        public void CoinValueUpgradeOnClick()
        {
            button.Click += CoinValueUpgradeFunctionality;
        }

        public void NextLevelButtonOnClick()
        {
            button.Click += NextLevelButtonFunctionality;
        }

        private void SpeedUpgradeFunctionality(object sender, EventArgs e)
        {
            if (!ChosenPlayer.CanPayThePrice(_speedUpgradePrice))
            {
                button.Text = "";
                button.BackColor = Color.Red;
            }
            else
            {
                button.Text = "BUY";
                button.BackColor = Color.FromArgb(18, 191, 2);
                ChosenPlayer.PayThePrice(_speedUpgradePrice);
                ChosenPlayer.SpeedUpgrade();
                if (_speedUpgradePrice == 2) UpgradePanel.speedUpgradeRectangles[0].ColorRectangle();
                else if (_speedUpgradePrice == 4) UpgradePanel.speedUpgradeRectangles[1].ColorRectangle();
                else if (_speedUpgradePrice == 8) UpgradePanel.speedUpgradeRectangles[2].ColorRectangle();
                else if (_speedUpgradePrice == 16) UpgradePanel.speedUpgradeRectangles[3].ColorRectangle();
                else if (_speedUpgradePrice == 32) UpgradePanel.speedUpgradeRectangles[4].ColorRectangle();
                _speedUpgradePrice *= 2;
            }
        }

        private void SizeUpgradeFunctionality(object sender, EventArgs e)
        {
            if (!ChosenPlayer.CanPayThePrice(_sizeUpgradePrice))
            {
                button.Text = ":(";
                button.BackColor = Color.Red;
            }
            else
            {
                button.Text = "BUY";
                button.BackColor = Color.FromArgb(18, 191, 2);
                ChosenPlayer.PayThePrice(_sizeUpgradePrice);
                ChosenPlayer.SizeUpgrade();
                if (_sizeUpgradePrice == 2) UpgradePanel.sizeUpgradeRectangles[0].ColorRectangle();
                else if (_sizeUpgradePrice == 4) UpgradePanel.sizeUpgradeRectangles[1].ColorRectangle();
                else if (_sizeUpgradePrice == 8) UpgradePanel.sizeUpgradeRectangles[2].ColorRectangle();
                else if (_sizeUpgradePrice == 16) UpgradePanel.sizeUpgradeRectangles[3].ColorRectangle();
                else if (_sizeUpgradePrice == 32) UpgradePanel.sizeUpgradeRectangles[4].ColorRectangle();
                _sizeUpgradePrice *= 2;
            }
        }
        private void CoinFindUpgradeFunctionality(object sender, EventArgs e)
        {
            if (!ChosenPlayer.CanPayThePrice(_coinFindUpgradePrice))
            {
                button.Text = ":(";
                button.BackColor = Color.Red;
            }
            else
            {
                button.Text = "BUY";
                button.BackColor = Color.FromArgb(18, 191, 2);
                ChosenPlayer.PayThePrice(_coinFindUpgradePrice);
                //ChosenPlayer.SpeedUpgrade();
                if (_coinFindUpgradePrice == 2) UpgradePanel.coinFindUpgradesRectangles[0].ColorRectangle();
                else if (_coinFindUpgradePrice == 4) UpgradePanel.coinFindUpgradesRectangles[1].ColorRectangle();
                else if (_coinFindUpgradePrice == 8) UpgradePanel.coinFindUpgradesRectangles[2].ColorRectangle();
                else if (_coinFindUpgradePrice == 16) UpgradePanel.coinFindUpgradesRectangles[3].ColorRectangle();
                else if (_coinFindUpgradePrice == 32) UpgradePanel.coinFindUpgradesRectangles[4].ColorRectangle();
                _coinFindUpgradePrice *= 2;
            }
        }
        private void CoinValueUpgradeFunctionality(object sender, EventArgs e)
        {
            if (!ChosenPlayer.CanPayThePrice(_coinValueUpgradePrice))
            {
                button.Text = ":(";
                button.BackColor = Color.Red;
            }
            else
            {
                button.Text = "BUY";
                button.BackColor = Color.FromArgb(18, 191, 2);
                ChosenPlayer.PayThePrice(_coinValueUpgradePrice);
                //ChosenPlayer.SpeedUpgrade();
                if (_coinValueUpgradePrice == 2) UpgradePanel.coinValueUpgradeRectangles[0].ColorRectangle();
                else if (_coinValueUpgradePrice == 4) UpgradePanel.coinValueUpgradeRectangles[1].ColorRectangle();
                else if (_coinValueUpgradePrice == 8) UpgradePanel.coinValueUpgradeRectangles[2].ColorRectangle();
                else if (_coinValueUpgradePrice == 16) UpgradePanel.coinValueUpgradeRectangles[3].ColorRectangle();
                else if (_coinValueUpgradePrice == 32) UpgradePanel.coinValueUpgradeRectangles[4].ColorRectangle();
                _coinValueUpgradePrice *= 2;
            }
        }
        public void NextLevelButtonFunctionality(object sender, EventArgs e)
        {
            UpgradePanel.DespawnUpgradePanel();
            Form1.form1._currentGameLevel++;
            Form1.form1.GameLevelsList[Form1.form1._currentGameLevel].SpawnGameLevelAndAddToCollideablesList();
            //Form1.form1._currentGameLevel++;
            Player.CoinsGrabbed = 0;
            Form1.form1.gameEngineTimer.Start();
        }
        public static List<Label1> priceLabel = new List<Label1>
        {
            new Label1(220, 150, $"{_speedUpgradePrice}", Color.Gold, 20),
        };

        public void SpawnLabels(Form1 formInstance)
        {
            foreach (var label in priceLabel) label.SpawnLabel();
        }
    }
}
