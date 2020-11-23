using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Spawner
    {
        //public static List<Collision> allCollideables = new List<Collision>();
        private static int screenWidth = 1379;
        private static int screenHeight = 748;
        private static readonly Random random = new Random();

        public static List<EnemyRectangle> EnemyList { get; } = new List<EnemyRectangle>
        {
            //new EnemyRectangle(Color.Aqua, 50, 100, "down", 16, 40, 40),
            //new EnemyRectangle(Color.Coral, 150, 200, "right", 23, 40, 40),
            //new EnemyRectangle(Color.Crimson, 350, 200, "down", 8, 40, 40),
            //new EnemyRectangle(Color.BlueViolet, 350, 400, "up", 11, 40, 40),
            //new EnemyRectangle(Color.Chartreuse, 550, 200, "right", 10, 40, 40),
            //new EnemyRectangle(Color.BurlyWood, 550, 340, "left", 5, 40, 40),
            //new EnemyRectangle(Color.CadetBlue, 42, 630, "left", 11, 40, 40),
            //new EnemyRectangle(Color.DeepPink, 42, 200, "left", 8, 40, 40),
            //new EnemyRectangle(Color.Gold, 42, 398, "down", 15, 40, 40),
            //new EnemyRectangle(Color.Tomato, 90, 500, "right", 12, 40, 40),
        };
        private void CreateRandomEnemies()
        {
            //var enemyCount = 15;
            //for (var i = 0; i < enemyCount; i++)
            //{
            //    string direction = null;
            //    var randomDirection = random.Next(0, 4);
            //    if (randomDirection == 0) direction = "up";
            //    else if (randomDirection == 1) direction = "down";
            //    else if (randomDirection == 2) direction = "left";
            //    else if (randomDirection == 3) direction = "right";
            //    int width = random.Next(20, 50);
            //    int height = random.Next(20, 50);
            //    int y = random.Next(0, screenHight - width);
            //    int x = random.Next(0, screenWidth - height);
            //    int Speed = random.Next(2, 25);
            //    //int Speed = 20;
            //    int randomRed = random.Next(0, 255 + 1);
            //    int randomGreen = random.Next(0, 255 + 1);
            //    int randomBlue = random.Next(0, 255 + 1);
            //    Color color = Color.Red;
            //    Color randomColor = Color.FromArgb(randomRed, randomGreen, randomBlue);
            //    EnemyList.Add(new EnemyRectangle(randomColor, x, y, direction, Speed, width, height));
            //}
        }
        public static List<Platform> PlatformList { get; } = new List<Platform>
        {
            /*new Platform("grassBiome", 1057, 40, Color.GreenYellow, 0, 530),*/
        };
        public static List<Player> PlayerList { get; } = new List<Player>
        {
            new Player(17, 8, 10, 0, "Player", 40, 40, Color.FromArgb(18, 191, 2), screenWidth/2, screenHeight/2+-50),
            new Player(26, 8, 10, 0, "Player", 20, 20, Color.FromArgb(255, 0, 2), screenWidth/2, screenHeight/2+-50),
            new Player(12, 8, 10, 0, "Player", 70, 70, Color.FromArgb(18, 32, 255), screenWidth/2, screenHeight/2+-50),
        };
        public static List<Coin> CoinList { get; } = new List<Coin>();
        public static List<EnemyRectangle> FirstLevelEnemies = new List<EnemyRectangle>
        {
            new EnemyRectangle(Color.Aqua, 50, 100, "down", 16, 40, 40, 1000),
            new EnemyRectangle(Color.Coral, 150, 200, "right", 23, 40, 40,500),
            new EnemyRectangle(Color.Crimson, 350, 200, "down", 8, 40, 40, 800),
        };
        public static List<Platform> FirstLevelPlatforms = new List<Platform>
        {

        };
        private static List<Coin> CreateRandomCoins(int coinAmount)
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
        public static List<Platform> InvisibleWallsList = new List<Platform>
        {
            new Platform("leftWall", 0, screenHeight, Color.Blue, 0, 0),
            new Platform("rightWall", 0, screenHeight, Color.Blue, screenWidth, 0),
            new Platform("topWall", screenWidth, 0, Color.Blue, 0, 0),
            new Platform("bottomWall", screenWidth, 0, Color.Blue, 0, screenHeight),
        };
        public static List<GameLevel> GameLevelsList;
        public static void GetPlayer(Player ChosenPlayer)
        {
            GameLevelsList = new List<GameLevel>
            {
                new GameLevel(ChosenPlayer, FirstLevelEnemies, FirstLevelPlatforms, CreateRandomCoins(20), InvisibleWallsList),
            };
        }
    }
}
