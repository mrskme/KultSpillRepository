using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Player : Rectangle1
    {
        private List<Coin> coinList;
        public static readonly Label coinLabel = new Label();
        private static int _walkingSpeed;
        private int _fallSpeed;
        private int _jumpHeight;
        private int _attackType;
        private int _coinCount;

        public Player(int walkingSpeed, int fallSpeed, int jumpHeight, int attackType,  
            string name, int width, int height, Color color, int x, int y)
            : base( name,  width,  height, color,  x,  y, false)
        {
            MakeCoinLabel();
            _walkingSpeed = walkingSpeed;
            _fallSpeed = fallSpeed;
            _jumpHeight = jumpHeight;
            _attackType = attackType;
        }
        public void grabACoin(Form1 formInstance)
        {
            coinList = GameLevel._coins;
            foreach (var coin in coinList)
            {
                if (isObjectColliding(this, coin) && coin.IsCoinVisible())
                {
                    _coinCount++;
                    UpdateCoinLabel();
                    coin.DespawnCoin(formInstance);
                }
                else if (IsObjectColliding(coin) && coin.IsCoinVisible())
                {
                    coin.DespawnCoin(formInstance);
                }
                //modifiableCoinList.Remove(coin);
            }
        }

        //public static bool isCoinListEmpty()
        //{
        //    return modifiableCoinList.Count == 0;
        //}
        public void UpdateCoinLabel()
        {
            coinLabel.Text = $"Gold: {_coinCount}";
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

        public void MakeCoinLabel()
        {
            coinLabel.Width = 150;
            coinLabel.Height = 50;
            coinLabel.Top = 6;
            coinLabel.Left = 918;
            coinLabel.Text = "Gold: 0";
            coinLabel.ForeColor = Color.Gold;
            coinLabel.BackColor = Color.Transparent;
            FontFamily fontFamily = new FontFamily("Times New Roman");
            Font font = new Font(fontFamily, 25);
            coinLabel.Font = font;
        }
    }
}
