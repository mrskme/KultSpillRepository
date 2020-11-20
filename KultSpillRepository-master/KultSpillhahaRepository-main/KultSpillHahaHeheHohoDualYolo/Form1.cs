using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    public partial class Form1 : Form
    {
        Spawner spawner = new Spawner();
        private List<EnemyRectangle> enemyList = Spawner.EnemyList;
        private Player player = Spawner.PlayerList[0];
        public Form1()
        {
            InitializeComponent();
            LoadGame();
        }
        private void LoadGame()
        {
            
            spawner.SpawnEverythingAndAddAllCollideablesToCollideablesList(this);
            this.Controls.Add(Player.coinLabel);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveEverything();
            player.grabACoin();
        }
        public void MoveEverything()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].MoveEnemyInDirection();
            }
            player.MovePlayer();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            GetMousePositionWindowsForms();
        }
        public static Point GetMousePositionWindowsForms()
        {
            var point = Control.MousePosition;
            return new Point(point.X, point.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
