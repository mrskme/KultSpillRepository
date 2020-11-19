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
        public static List<Collision> allCollideables = new List<Collision>();
        private int screenWidth = 1057;
        private int screenHight = 567;
        private readonly Random random = new Random();

        public static List<EnemyRectangle> EnemyList { get; } = new List<EnemyRectangle>
        {
            //new EnemyRectangle(Color.Aqua, 50, 100, "down", 15, 40, 40),
            //new EnemyRectangle(Color.Coral, 150, 200, "right", 23, 40, 40),
            //new EnemyRectangle(Color.Crimson, 350, 200, "down", 7, 40, 40),
            //new EnemyRectangle(Color.BlueViolet, 350, 400, "up", 10, 40, 40),
            //new EnemyRectangle(Color.Chartreuse, 550, 200, "right", 9, 40, 40),
            //new EnemyRectangle(Color.BurlyWood, 550, 340, "left", 4, 40, 40),
            //new EnemyRectangle(Color.CadetBlue, 42, 400, "left", 10, 40, 40),
            //new EnemyRectangle(Color.DeepPink, 42, 200, "up", 7, 40, 40),
        };
        private void MakeRandomEnemies()
        {
            var enemyCount = 20;
            for (var i = 0; i < enemyCount; i++)
            {
                string direction = null;
                var randomDirection = random.Next(0, 4);
                if (randomDirection == 0) direction = "up";
                else if (randomDirection == 1) direction = "down";
                else if (randomDirection == 2) direction = "left";
                else if (randomDirection == 3) direction = "right";
                int width = random.Next(7, 50);
                int height = random.Next(7, 50);
                int y = random.Next(0, screenHight - width);
                int x = random.Next(0, screenWidth - height);
                int Speed = random.Next(2, 25);
                EnemyList.Add(new EnemyRectangle(Color.Red, x, y, direction, Speed, width, height));
            }
        }
        public static List<Platform> PlatformList { get; } = new List<Platform>
        {
            /*new Platform("grassBiome", 1057, 40, Color.GreenYellow, 0, 530),*/
        };
        public static List<Player> PlayerList { get; } = new List<Player>
        {
            new Player(16, 8, 10, 0, "Chosen", 30, 30, Color.DodgerBlue, 524, 283 /*, 0, null*/)
        };
        public static List<Coin> TestCoin { get; } = new List<Coin>
        {
            //new Coin(50, 233),
        };
        private void MakeCoins()
        {
            var coinAmount = 50;
            var SpaceBetweenCoinAndWall = 6;
            for (var i = 0; i < coinAmount; i++)
            {
                var x = random.Next(0 ,screenWidth - 17 - SpaceBetweenCoinAndWall);
                var y = random.Next(0, screenHight - 24 - SpaceBetweenCoinAndWall);
                TestCoin.Add(new Coin(x, y));
            }
        }
        public static List<Platform> InvisibleWallsList = new List<Platform>
        {
            new Platform("leftWall", 0, 567, Color.Blue, 0, 0),
            new Platform("rightWall", 0, 567, Color.Blue,1057,0),
            new Platform("topWall", 1057, 0, Color.Blue, 0 ,0 ),
            new Platform("bottomWall", 1057, 0, Color.Blue,0, 567),
        };

        public void SpawnEverythingAndAddCollideablesToCollideableList(Form1 formInstance)
        {
            MakeCoins();
            MakeRandomEnemies();
            PlayerList[0].SpawnRectangle(formInstance);
            allCollideables.Add(PlayerList[0]);

            foreach (var enemy in EnemyList)
            {
                enemy.SpawnRectangle(formInstance);
                allCollideables.Add(enemy);
            }
            foreach (var platform in PlatformList)
            {
                platform.SpawnRectangle(formInstance);
                allCollideables.Add(platform);
            }
            foreach (var wall in InvisibleWallsList)
            {
                wall.SpawnRectangle(formInstance);
                allCollideables.Add(wall);
            }
            foreach (var coin in TestCoin)
            {
                coin.SpawnRectangle(formInstance);
            }
        }
        //public void SpawnEnemiesAndAddThemToCollideableList() bedre eller værre?
        //{

        //}
    }
}
