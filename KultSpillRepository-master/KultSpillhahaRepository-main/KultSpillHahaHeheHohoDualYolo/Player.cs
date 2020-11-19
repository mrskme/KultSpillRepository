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
        //private static List<Collision> allObjectList = Spawner.allCollideables;
        private List<Coin> coinList;

        public Label coinLabel = Coin.coinLabel;
        private static int _walkingSpeed;
        private int _fallSpeed;
        private int _jumpHeight;
        private int _attackType;
        private int _coinCount;

        public Player(int walkingSpeed, int fallSpeed, int jumpHeight, int attackType,  
            string name, int width, int height, Color color, int x, int y)
            : base( name,  width,  height, color,  x,  y, false)
        {
            _walkingSpeed = walkingSpeed;
            _fallSpeed = fallSpeed;
            _jumpHeight = jumpHeight;
            _attackType = attackType;
            //NewRectangle.BringToFront(); ???
        }
        public void grabACoin()
        {
            coinList = Spawner.TestCoin;
            foreach (var coin in coinList)
            {
                //Noen måter å sjekke om det er player som plukker opp coinen? 
                if (IsObjectColliding(coin) && coin.IsCoinVisible())
                {
                    _coinCount++;
                    coin.MakeCoinInvisible();
                    UpdateCoinLabel();
                }
            }
        }
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
        //public void MovePlayerInDirection()
        //{
        //    var oldTop = NewRectangle.Top;
        //    var oldLeft = NewRectangle.Left;

        //    if (_direction == "down") NewRectangle.Top += _walkingSpeed;
        //    else if (_direction == "up") NewRectangle.Top -= _walkingSpeed;
        //    else if (_direction == "left") NewRectangle.Left -= _walkingSpeed;
        //    else if (_direction == "right") NewRectangle.Left += _walkingSpeed;

        //    if (IsObjectColliding(this))
        //    {
        //        NewRectangle.Top = oldTop;
        //        NewRectangle.Left = oldLeft;
        //    }
        //}
    }
}
