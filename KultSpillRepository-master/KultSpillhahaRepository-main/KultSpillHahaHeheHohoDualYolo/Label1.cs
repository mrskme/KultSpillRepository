using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Label1
    {
        private Label label = new System.Windows.Forms.Label();
        //private int _width;
        //private int _height;
        //private string _text;
        //private Color _backColor;
        public Label1(int x, int y, string text, Color backColor, int textSize)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            Font font = new Font(new FontFamily("Times New Roman"), textSize);
            label.Font = font;
            label.Text = text;
            //label.BackColor = backColor;
            //_backColor = backColor;
            label.BackColor = Color.Gold;
        }

        public void SpawnLabel(Form1 formInstance)
        {
            formInstance.Controls.Add(label);
        }

        
    }
}
