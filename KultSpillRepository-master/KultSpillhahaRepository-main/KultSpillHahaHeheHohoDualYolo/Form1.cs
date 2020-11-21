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
        private List<Player> playerList = Spawner.PlayerList;
        private List<GameLevel> GameStageList = Spawner.GameStageList;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame(Player player)
        {
            Controls.Remove(label1);
            Controls.Remove(button1);
            Controls.Remove(button2);
            Controls.Remove(button3);
            //spawner.SpawnEverythingAndAddAllCollideablesToCollideablesList(this);
            GameStageList[0].SpawnGameLevels(this, player);
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

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame(playerList[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartGame(playerList[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartGame(playerList[2]);
        }

        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    GetMousePositionWindowsForms();
        //}
        //public static Point GetMousePositionWindowsForms()
        //{
        //    var point = Control.MousePosition;
        //    return new Point(point.X, point.Y);
        //}
    }
}
