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
            new EnemyRectangle(Color.Aqua, 50,100,"down",0),
            new EnemyRectangle(Color.Coral, 150, 200,"down", 3),
            //new EnemyRectangle(4, Color.Crimson, 350, 200, "down"),
            //new EnemyRectangle(4, Color.BlueViolet, 350, 400, "up"),
            //new EnemyRectangle(8, Color.Chartreuse, 450, 500, "left"),
            //new EnemyRectangle(10, Color.BurlyWood, 550, 600, "left"),
        };
        public static List<Platform> PlatformList { get; } = new List<Platform>
        {
            new Platform("grassBiome", 1100, 40, Color.GreenYellow, 0, 530),
        };
        public static List<Player> PlayerList { get; } = new List<Player>
        {
            new Player(12, 8, 10, 0, "Chosen", 40, 60, Color.DarkMagenta, 150, 100, 0, null)
        };
        public static List<Coin> TestCoin { get; } = new List<Coin>
        {
            new Coin(15, 24, 30, 255),
            new Coin(15, 24, 291, 2),
            new Coin(15, 24, 1000, 49),
            new Coin(15, 24, 756, 155),
            new Coin(15, 24, 104, 390),
            new Coin(15, 24, 145, 400),
        };
        public void CreateEnemies(Form1 formInstance)
        {
            for (int i = 0; i < EnemyList.Count; i++)
            {
                EnemyList[i].SpawnRectangle(formInstance);
            }
        }
        public void CreateGround(Form1 formInstance)
        {
            for (int i = 0; i < PlatformList.Count; i++) 
            {
                PlatformList[i].SpawnRectangle(formInstance);
            }
        }
        public void CreatePlayer(Form1 formInstance)
        {
            PlayerList[0].SpawnRectangle(formInstance);
        }

        public void CreateTestCoin(Form1 formInstance)
        {
            foreach (var coin in TestCoin)
            {
                coin.SpawnRectangle(formInstance);
            }
        }
        public void addAllCollideablesToList()
        {
            foreach (var enemy in EnemyList)
            {
                allCollideables.Add(enemy);
            }
            foreach (var platform in PlatformList)
            {
                allCollideables.Add(platform);
            }
            foreach (var player in PlayerList)
            {
                allCollideables.Add(player);
                //legg til brukervalgt player
            }
        }
    }
}
