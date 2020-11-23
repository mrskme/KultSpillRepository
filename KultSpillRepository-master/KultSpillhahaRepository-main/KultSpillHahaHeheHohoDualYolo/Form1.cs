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
        private List<GameLevel> GameLevelsList;
        private List<EnemyRectangle> enemyList;
        //private Player chosenPlayer = GameLevel._player;
        private static Player chosenPlayer;
        public Form1()
        {
            InitializeComponent();
            gameEngineTimer.Stop();
        }
        private void StartGame()
        {
            gameEngineTimer.Start();
            Controls.Remove(label1);
            Controls.Remove(button1);
            Controls.Remove(button2);
            Controls.Remove(button3);
            enemyList = GameLevel._enemies;
            LoadGame();
            this.Controls.Add(Player.coinLabel);
            foreach (var enemy in enemyList) enemy.RandomDirectionTimer();
        }

        private void LoadGame()
        {
            GameLevelsList = Spawner.GameLevelsList;
            GameLevelsList[0].SpawnGameLevelAndAddToCollideablesList(this);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveEverything();
            chosenPlayer.GrabCoinAndShowUpgradesIfNoMoreCoinsOnScreen(this);
            SpawnUpgradePanel();
        }
        private void SpawnUpgradePanel()
        {
            // implementer en måte sånn at SpawnUpgradePanel bare kjører en gang så får vi se
            // det var fortere gjort enn sagt
            if (chosenPlayer.IsNoMoreCoins())
            {
                GameLevelsList[0].DespawnAllObjects(this);
                UpgradePanel.CreateUpgradePanel(this);
                gameEngineTimer.Stop();
            }
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
            Spawner.GetPlayer(playerList[0]);
            chosenPlayer = GameLevel._player;
            StartGame();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Spawner.GetPlayer(playerList[1]);
            chosenPlayer = GameLevel._player;
            StartGame();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Spawner.GetPlayer(playerList[2]);
            chosenPlayer = GameLevel._player;
            StartGame();
        }
        //private void Form1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    GetMousePosition();
        //}
        //public static Point GetMousePosition()
        //{
        //    var point = Control.MousePosition;
        //    return new Point(point.X, point.Y);
        //}
    }
}
