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
        //private Player player = Spawner.PlayerList[0];
        private List<Player> playerList = Spawner.PlayerList;
        private List<GameLevel> GameStageList = Spawner.GameLevelsList;
        private List<EnemyRectangle> enemyList = GameLevel._enemies;
        //private Player chosenPlayer = GameLevel._player;
        private static Player chosenPlayer;
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            Controls.Remove(label1);
            Controls.Remove(button1);
            Controls.Remove(button2);
            Controls.Remove(button3);
            //spawner.SpawnEverythingAndAddAllCollideablesToCollideablesList(this);
            GameStageList[0].SpawnGameLevels(this, chosenPlayer);
            this.Controls.Add(Player.coinLabel);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveEverything();
            chosenPlayer.grabACoin();
        }
        public void MoveEverything()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].MoveEnemyInDirection();
            }
            chosenPlayer.MovePlayer();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //StartGame(playerList[0]);
            //Spawner.ChosePlayer(playerList[0]);
            chosenPlayer = playerList[0];
            StartGame();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //StartGame(playerList[1]);
            chosenPlayer = playerList[1];
            StartGame();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //StartGame(playerList[2]);
            //return playerList[2];
            chosenPlayer = playerList[2];
            StartGame();
        }
        private Player GetChosenPlayer()
        {
            return chosenPlayer;
        }
        //private Player CHosePlayer(Player player)
        //{
        //    return player;
        //}

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
