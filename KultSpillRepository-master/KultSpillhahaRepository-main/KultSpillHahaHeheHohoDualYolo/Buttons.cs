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

        public Buttons(Point location, int width, int height)
        {
            button.BackColor = Color.Gold;
            button.Width = width;
            button.Height = height;
            button.Location = location;
        }

        public void SpawnButton(Form1 formInstance)
        {
            formInstance.Controls.Add(button);
        }
        //button.BackColor = Color.Gold;
        //_player.PayUpgradePrice();
        //button.Click += _player.UpgradePlayer;
        //speedUpgradeRectangles[0].ColorRectangle();
        //speedUpgradeRectangles[0].SpawnRectangle(formInstance);
        //button.Width = 50;
        //button.Height = 25;
        //button.Location = new Point(40,155);
        //formInstance.Controls.Add(button);
    }
}
