using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Spawner
    {
        public static List<Collision> allCollideables = new List<Collision>();

        public static List<EnemyRectangle> EnemyList { get; } = new List<EnemyRectangle>
        {
            new EnemyRectangle(Color.Aqua, 50, 100, "down", 15),
            new EnemyRectangle(Color.Coral, 150, 200, "right", 23),
            new EnemyRectangle(Color.Crimson, 350, 200, "down", 7),
            new EnemyRectangle(Color.BlueViolet, 350, 400, "up", 10),
            new EnemyRectangle(Color.Chartreuse, 550, 200, "right", 9),
            new EnemyRectangle(Color.BurlyWood, 550, 340, "left", 4),
            new EnemyRectangle(Color.CadetBlue, 42, 400, "left", 10),
            new EnemyRectangle(Color.DeepPink, 42, 200, "up", 7),
        };

        public static List<Platform> PlatformList { get; } = new List<Platform>
        {
            /*new Platform("grassBiome", 1057, 40, Color.GreenYellow, 0, 530),*/ //screenwidth = 1057, screenHight = 567

        };

        public static List<Player> PlayerList { get; } = new List<Player>
        {
            new Player(16, 8, 10, 0, "Chosen", 30, 30, Color.DodgerBlue, 524, 283 /*, 0, null*/)
        };

        //private void RandomCoinLocations()
        //{
        //Random random = new Random();
        //    foreach (var coin in TestCoin)
        //    {
        //        int x = random.Next();
        //        int y = random.Next();
        //    }
        //}
        private void randomnumberhaha()
        {
            Random random = new Random(); 
            var tilfeldigTallMellom10Og14 = random.Next(10, 15);
        }
        
        public static List<Coin> TestCoin { get; } = new List<Coin>
        {
            new Coin(30, 255),
            new Coin(291, 2),
            new Coin(110, 49),
            new Coin(756, 155),
            new Coin(104, 390),
            new Coin(145, 400),
        };

        public static List<Platform> InvisibleWallsList = new List<Platform>
        {
            new Platform("leftWall", 0, 567, Color.Blue, 0, 0),
            new Platform("rightWall", 0, 567, Color.Blue,1057,0),
            new Platform("topWall", 1057, 0, Color.Blue, 0 ,0 ),
            new Platform("bottomWall", 1057, 0, Color.Blue,0, 567),
        };

        public void SpawnEverythingAndAddCollideablesToCollideableList(Form1 formInstance)
        {
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
