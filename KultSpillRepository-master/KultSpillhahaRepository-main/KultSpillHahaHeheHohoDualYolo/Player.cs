using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Player : Rectangle1
    {
        private static List<Collision> allObjectList = Spawner.allCollideables;
        //hvorfor er ikke resharper available
        //hvorfor lagger spilleren når jeg velger en ny retning
        private static int _walkingSpeed;
        private static int _currentSpeed;
        private static string _direction;
        private int _fallSpeed;
        private int _jumpHeight;
        private int _attackType;

        public Player(int walkingSpeed, int fallSpeed, int jumpHeight, int attackType,  
            string name, int width, int height, Color color, int x, int y, int currentSpeed, string direction)
            : base( name,  width,  height, color,  x,  y, false)
        {
            _walkingSpeed = walkingSpeed;
            _currentSpeed = currentSpeed;
            _direction = direction;
            _fallSpeed = fallSpeed;
            _jumpHeight = jumpHeight;
            _attackType = attackType;
        }
        internal static void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.A)
                {
                    _direction = "left";
                }
                if (e.KeyCode == Keys.D)
                {
                    _direction = "right";
                }
                if (e.KeyCode == Keys.S)
                {
                    _direction = "down";
                }
                if (e.KeyCode == Keys.W)
                {
                    _direction = "up";
                }
                //MovePlayerInDirection()
            }
        }
        internal static void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || 
                e.KeyCode == Keys.D || 
                e.KeyCode == Keys.S || 
                e.KeyCode == Keys.W)
            {
                _direction = null;
            }
        }

        public void IfKeyDown()
        {
            if (Keyboard.IsKeyDown(Key.A)) /*_direction = "left";*/ NewRectangle.Left -= _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.D)) /*_direction = "right";*/ NewRectangle.Left += _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.S)) /*_direction = "down";*/ NewRectangle.Top += _walkingSpeed;
            if (Keyboard.IsKeyDown(Key.W)) /*_direction = "up";*/ NewRectangle.Top -= _walkingSpeed;
        }
        public void MovePlayerInDirection()
        {
            var oldTop = NewRectangle.Top;
            var oldLeft = NewRectangle.Left;

            if (_direction == "down") NewRectangle.Top += _walkingSpeed;
            else if (_direction == "up") NewRectangle.Top -= _walkingSpeed;
            else if (_direction == "left") NewRectangle.Left -= _walkingSpeed;
            else if (_direction == "right") NewRectangle.Left += _walkingSpeed;

            if (IsObjectColliding(this))
            {
                NewRectangle.Top = oldTop;
                NewRectangle.Left = oldLeft;
            }
        }
    }
}
