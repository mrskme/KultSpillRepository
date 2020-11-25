using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Player : Rectangle1
    {
        private List<Coin> coinList;
        ////public static readonly Label coinLabel = new Label();
        private int _walkingSpeed;
        private int _fallSpeed;
        private int _jumpHeight;
        private int _attackType;

        private static double _PlayerOwnedCoins= 100000;
        public static int CoinsGrabbed;
        private static double plusCoins = 1d;
        private static int _gold;
        private static int _silver;
        private static int _bronze;

        private List<Label1> CoinLabelList = new List<Label1>
        {
            new Label1(1100, 15, Convert.ToString(_gold), Color.Gold, 25),
            new Label1(1200, 15, Convert.ToString(_bronze), Color.Silver, 25),
            new Label1(1300, 15, Convert.ToString(_silver), Color.SaddleBrown, 25),
        };
        private static List<Rectangle1> CoinTypeRectangles = new List<Rectangle1>
        {
            new Rectangle1("Gold", 17, 24, Color.Gold, 550, 500, true),
        }; 
        private void CalculateMoney()
        {
            var Coincount = Convert.ToInt32(_PlayerOwnedCoins);
            _gold = Coincount / 10000;
            Coincount -= _gold * 10000;
            _silver = Coincount / 100;
            _bronze = Coincount - _silver * 100;
        }
        private void MakeMoneyLabels()
        {
            CalculateMoney(); 
            foreach (var CoinLabel in CoinLabelList) CoinLabel.SpawnLabel();
        }

        public Player(int walkingSpeed, int fallSpeed, int jumpHeight, int attackType,  
            string name, int width, int height, Color color, int x, int y)
            : base( name,  width,  height, color,  x,  y, false)
        {
            //coinLabel.SendToBack();
            _walkingSpeed = walkingSpeed;
            _fallSpeed = fallSpeed;
            _jumpHeight = jumpHeight;
            _attackType = attackType;

        }
        public void GrabCoinAndShowUpgradesIfNoMoreCoinsOnScreen(List<GameLevel> GameLevelList)
        {
            MakeMoneyLabels();
            coinList = GameLevelList[Form1.form1._currentGameLevel]._coins;
            foreach (var coin in coinList)
            {
                if (isObjectColliding(this, coin) && coin.IsCoinVisible())
                {
                    _PlayerOwnedCoins += plusCoins;
                    UpdateCoinLabel();
                    coin.DespawnCoin();
                    CoinsGrabbed++;
                }
                else if (IsObjectColliding(coin) && coin.IsCoinVisible())
                {
                    coin.DespawnCoin();
                    CoinsGrabbed++;
                }
            }
        }
        public bool IsNoMoreCoins()
        {
            return CoinsGrabbed == coinList.Count;
        }
        public void UpdateCoinLabel()
        {
            CoinLabelList[0].UpdateLabel(Convert.ToString(_gold));
            CoinLabelList[1].UpdateLabel(Convert.ToString(_silver));
            CoinLabelList[2].UpdateLabel(Convert.ToString(_bronze));
        }
        public void MovePlayer()
        {
            var oldTop = NewRectangle.Top;
            var oldLeft = NewRectangle.Left;

            if (Keyboard.IsKeyDown(Key.A)) NewRectangle.Left -= _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.D)) NewRectangle.Left += _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.S)) NewRectangle.Top += _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.W)) NewRectangle.Top -= _walkingSpeed;

            if (IsObjectColliding(this))
            {
                NewRectangle.Top = oldTop;
                NewRectangle.Left = oldLeft;
            }
        }
        //public void MakeCoinLabel()
        //{
        //    coinLabel.AutoSize = true;
        //    coinLabel.Top = 6;
        //    coinLabel.Left = 1220;
        //    coinLabel.Text = "Gold: 0";
        //    coinLabel.ForeColor = Color.Gold;
        //    coinLabel.BackColor = Color.Transparent;
        //    FontFamily fontFamily = new FontFamily("Times New Roman");
        //    Font font = new Font(fontFamily, 25);
        //    coinLabel.Font = font;
        //    //Label1 label = new Label1(918, 6, "Gold: 0", Color.Gold, 25);
        //    //label.SpawnLabel(form);
        //}

        public void PayThePrice(int price)
        {
            _PlayerOwnedCoins -= price;
            UpdateCoinLabel();
        }

        public bool CanPayThePrice(int price)
        {
            return _PlayerOwnedCoins >= price;
        }
        public void SpeedUpgrade()
        {
            _walkingSpeed+= 2;
            UpdateCoinLabel();
        }

        public void SizeUpgrade()
        {
            NewRectangle.Width += 4;
            NewRectangle.Height += 4;
            UpdateCoinLabel();
        }
        public void CoinValueUpgrade()
        {
            var moneyMultiplier = 1.2;
            plusCoins *= moneyMultiplier;
            UpdateCoinLabel();
        }
    }
}
