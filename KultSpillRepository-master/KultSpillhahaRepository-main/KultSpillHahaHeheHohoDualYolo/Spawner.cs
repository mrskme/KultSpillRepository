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
        public static List<Collision> allObjects = new List<Collision>();
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
            new Player(5, 8, 10, 0, "Chosen", 40, 60, Color.DarkMagenta, 150, 100, 0, null)
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
        public void addAllObjectsToList()
        {
            foreach (var enemy in EnemyList)
            {
                allObjects.Add(enemy);
            }
            foreach (var platform in PlatformList)
            {
                allObjects.Add(platform);
            }
            foreach (var player in PlayerList)
            {
                allObjects.Add(player);
                //legg til brukervalgt player
            }
        }
    }
}
