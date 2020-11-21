using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void SpawnGameLevels(Form1 formInstance, Player player)
        {
            //er det noe bedre måter enn å gjøre alt static for å kjøre denne i form1?
            allCollideables.Add(player);
            player.SpawnRectangle(formInstance);

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
    }
}
