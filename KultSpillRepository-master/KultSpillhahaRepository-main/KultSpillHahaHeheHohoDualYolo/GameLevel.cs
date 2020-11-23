using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class GameLevel
    {
        public static Player _player;
        public static  List<EnemyRectangle> _enemies;
        public static List<Platform> _platforms;
        public static List<Coin> _coins;
        private static List<Platform> _invisibleWalls;
        public static List<Collision> allCollideables = new List<Collision>();


        public GameLevel(Player player, List<EnemyRectangle> enemies, List<Platform> platforms, List<Coin> coins, List<Platform> invisibleWalls)
        {
            _player = player;
            _enemies = enemies;
            _platforms = platforms;
            _coins = coins;
            _invisibleWalls = invisibleWalls;
        }
        public void SpawnGameLevelAndAddToCollideablesList(Form1 formInstance/*, Player player*/)
        {
            allCollideables.Add(_player);
            _player.SpawnRectangle(formInstance);

            foreach (var enemy in _enemies)
            {
                enemy.SpawnRectangle(formInstance);
                allCollideables.Add(enemy);
            }

            foreach (var platform in _platforms)
            {
                allCollideables.Add(platform);
                platform.SpawnRectangle(formInstance);
            }

            foreach (var coin in _coins)
            {
                coin.SpawnRectangle(formInstance);
            }

            foreach (var invisibleWall in _invisibleWalls)
            {
                allCollideables.Add(invisibleWall);
                invisibleWall.SpawnRectangle(formInstance);
            }
        }
        public static void ShowUpgradePanel(Form1 formInstance)
        { 
            allCollideables.Clear();
            DespawnAllObjects(formInstance);
            UpgradePanel(formInstance);
        }

        private static void DespawnAllObjects(Form1 formInstance)
        {
            _player.DespawnRectangle(formInstance);
            foreach (var enemy in _enemies)
            {
                enemy.DespawnRectangle(formInstance);
            }

            foreach (var platform in _platforms)
            {
                platform.DespawnRectangle(formInstance);
            }

            foreach (var coin in _coins)
            {
                coin.DespawnRectangle(formInstance);
            }

            foreach (var invisibleWall in _invisibleWalls)
            {
                invisibleWall.DespawnRectangle(formInstance);
            }
        }

        static List<UpgradeDisplayerRectangle> speedUpgradeRectangles = new List<UpgradeDisplayerRectangle>
        {
            //new Rectangle1("kake", 5, 5, Color.Gold, 50, 50, true),
            new UpgradeDisplayerRectangle(Color.Gold,/* Color.Green,*/  510, 190),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  560, 190),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  610, 190),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  660, 190),
            new UpgradeDisplayerRectangle(Color.Transparent,/* Color.Green,*/  710, 190),
        };

        static List<Label1> labelList = new List<Label1>
        {
            new Label1(250, 200, "Speed:", Color.Transparent, 19),
            new Label1(250, 300, "Size:", Color.Transparent, 19),
            new Label1(250, 400, "Coin find chance:", Color.Transparent, 19),
            new Label1(250, 500, "Coin value:", Color.Transparent, 19),
        };
        public static void UpgradePanel(Form1 formInstance)
        {
            CreateChoseYourUpgradeLabel(formInstance);
            UpgradeButton();
            foreach (var rectangle in speedUpgradeRectangles)
            {
                rectangle.SpawnRectangle(formInstance);
            }

            foreach (var label in labelList)
            {
                label.SpawnLabel(formInstance);
            }
        }

        public static void CreateChoseYourUpgradeLabel(Form1 formInstance)
        {
            var label = new System.Windows.Forms.Label();
            label.Width = 279;
            label.Height = 48;
            label.Location = new Point(30, 30);
            Font font = new Font(new FontFamily("Times New Roman"), 25);
            label.Font = font;
            label.Text = "Pick your upgrades";
            label.BackColor = Color.Gold;
            formInstance.Controls.Add(label);
        }

        public static void UpgradeButton()
        {
            //var button = new Button();
            //button.Click += new System.EventHandler(_player.UpgradePlayer("walkingSpeed"));
        }

    }
}
