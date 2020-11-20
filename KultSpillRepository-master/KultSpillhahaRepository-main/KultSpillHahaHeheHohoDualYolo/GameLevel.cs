using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KultSpillHahaHeheHohoDualYolo
{
    class GameLevel
    {
        private Player _player;
        private List<EnemyRectangle> _enemies;
        private List<Platform> _platforms;
        private List<Coin> _coins;

        public GameLevel(Player player, List<EnemyRectangle> enemies, List<Platform> platforms, List<Coin> coins)
        {
            _player = player;
            _enemies = enemies;
            _platforms = platforms;
            _coins = coins; 
        }
    }
}
