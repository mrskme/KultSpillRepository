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
        public Label1(int x, int y, string text, Color foreColor, int textSize)
        {
            label.AutoSize = true;
            label.Location = new Point(x, y);
            Font font = new Font(new FontFamily("Times New Roman"), textSize);
            label.Font = font;
            label.Text = text;
            //label.BackColor = foreColor;
            //_backColor = foreColor;
            label.ForeColor = foreColor;
            //label.BackColor = Color.Gold;
        }

        public void SpawnLabel( )
        {
            Form1.form1.Controls.Add(label);
        }

        public void DespawnLabel( )
        {
            Form1.form1.Controls.Remove(label);
        }

        public void UpdateLabel(string text)
        {
            label.Text = text;
        }
    }
}
