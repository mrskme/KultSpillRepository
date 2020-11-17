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
        public static List<EnemyRectangle> EnemyList { get; } = new List<EnemyRectangle>
        {
            new EnemyRectangle(2, "down", Color.Aqua, 50, 100),
            new EnemyRectangle(1, "up", Color.Coral, 150, 200),
            new EnemyRectangle(4, "down", Color.Crimson, 350, 200),
            new EnemyRectangle(4, "up", Color.BlueViolet, 350, 400),
            new EnemyRectangle(8, "left", Color.Chartreuse, 450, 500),
            new EnemyRectangle(10, "left", Color.BurlyWood, 550, 600),
        };

        public static List<Ground> GroundList { get; } = new List<Ground>
        {
            new Ground("grassBiome", 700, 40, true, Color.GreenYellow, 100, 100),
        };
        
        public void CreateEnemies(Form1 formInstance)
        {
            for (int i = 0; i < EnemyList.Count; i++)
            {
                EnemyList[i].SpawnRectangle(formInstance);
            }
        }

        public void CreateGroundi(Form1 formInstance)
        {
            for (int i = 0; i < GroundList.Count; i++) 
            {
                GroundList[i].SpawnRectangle(formInstance);
            }
        }
        //static for å lage objekt av klassen
    }
}
