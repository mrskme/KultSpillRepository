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
        public static Form1 form1;
        private static int screenWidth = 1379;
        private static int screenHeight = 748;
        private readonly Random random = new Random();
        public int _currentGameLevel = 0;

        private List<Player> _PlayerList = new List<Player>
        {
            new Player(17, 8, 10, 0, "Player", 40, 40, Color.FromArgb(18, 191, 2), screenWidth/2, screenHeight/2+-50),
            new Player(26, 8, 10, 0, "Player", 20, 20, Color.FromArgb(255, 0, 2), screenWidth/2, screenHeight/2+-50),
            new Player(12, 8, 10, 0, "Player", 70, 70, Color.FromArgb(18, 32, 255), screenWidth/2, screenHeight/2+-50),
        };
        private List<EnemyRectangle> FirstLevelEnemies = new List<EnemyRectangle>
        {
            new EnemyRectangle(Color.Aqua, 50, 100, "down", 16, 40, 40, 1000),
            new EnemyRectangle(Color.Coral, 150, 200, "right", 23, 40, 40,500),
            new EnemyRectangle(Color.Crimson, 350, 200, "down", 8, 40, 40, 800),
        };
        private List<EnemyRectangle> SecondLevelEnemies = new List<EnemyRectangle>
        {
            new EnemyRectangle(Color.Aqua, 50, 100, "down", 16, 40, 40, 1000),
            new EnemyRectangle(Color.Coral, 150, 200, "right", 23, 40, 40,500),
            new EnemyRectangle(Color.Crimson, 350, 200, "down", 8, 40, 40, 800),
            new EnemyRectangle(Color.Black, 550, 372, "down", 8, 40, 40, 300),
        };
        private List<Platform> FirstLevelPlatforms = new List<Platform>
        {

        };
        private List<Platform> SecondLevelPlatforms = new List<Platform>
        {

        };

        private List<Coin> CoinList { get; } = new List<Coin>();
        private List<Coin> CreateRandomCoins(int coinAmount)
        {
            var SpaceBetweenCoinAndWall = 6;
            for (var i = 0; i < coinAmount; i++)
            {
                var x = random.Next(0, screenWidth - 17 - SpaceBetweenCoinAndWall);
                var y = random.Next(0, screenHeight - 24 - SpaceBetweenCoinAndWall);
                CoinList.Add(new Coin(x, y));
            }
            return CoinList;
        }
        private List<Platform> InvisibleWallsList = new List<Platform>
        {
            new Platform("leftWall", 0, screenHeight, Color.Blue, 0, 0),
            new Platform("rightWall", 0, screenHeight, Color.Blue, screenWidth, 0),
            new Platform("topWall", screenWidth, 0, Color.Blue, 0, 0),
            new Platform("bottomWall", screenWidth, 0, Color.Blue, 0, screenHeight),
        };

        internal List<GameLevel> GameLevelsList { get; set; }

        private void GetPlayer(Player ChosenPlayer)
        {
            GameLevelsList = new List<GameLevel>
            {
                new GameLevel(ChosenPlayer, FirstLevelEnemies, FirstLevelPlatforms, CoinList, InvisibleWallsList),
                new GameLevel(ChosenPlayer, SecondLevelEnemies, FirstLevelPlatforms, CoinList, InvisibleWallsList),
            };
        }
        public Form1()
        {
            form1 = this;
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
            //enemyList = GameLevel._enemies;
            LoadGame();
            this.Controls.Add(Player.coinLabel);
            foreach (var enemy in GameLevelsList[_currentGameLevel]._enemies) enemy.RandomDirectionTimer();
        }

        private void LoadGame()
        {
            //GameLevelsList = Spawner.GameLevelsList;
            CreateRandomCoins(10);
            GameLevelsList[_currentGameLevel].SpawnGameLevelAndAddToCollideablesList();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GameLevelsList[_currentGameLevel].MoveEverything();
            GameLevel._player.GrabCoinAndShowUpgradesIfNoMoreCoinsOnScreen(GameLevelsList);
            SpawnUpgradePanel();
        }
        private void SpawnUpgradePanel()
        {
            if (GameLevel._player.IsNoMoreCoins())
            {
                GameLevelsList[_currentGameLevel].DespawnAllObjects();
                UpgradePanel.CreateUpgradePanel();
                CoinList.Clear();
                CreateRandomCoins(20);
                gameEngineTimer.Stop();
            }
        }
        //public void MoveEverything()
        //{
        //    for (int i = 0; i < enemyList.Count; i++)
        //    {
        //        enemyList[i].MoveEnemyInDirection();
        //    }
        //    chosenPlayer.MovePlayer();
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            /*Spawner.*/GetPlayer(_PlayerList[0]);
            //chosenPlayer = GameLevel._player;
            StartGame();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetPlayer(_PlayerList[1]);
            //chosenPlayer = GameLevel._player;
            StartGame();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GetPlayer(_PlayerList[2]);
            //chosenPlayer = GameLevel._player;
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
