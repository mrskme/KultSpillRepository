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
        Spawner spawner = new Spawner();
        private List<Coin> coinList = Spawner.TestCoin;
        private List<EnemyRectangle> enemyList = Spawner.EnemyList;
        private Player player = Spawner.PlayerList[0];
        public Form1()
        {
            InitializeComponent();
            LoadGame();
        }
        private void LoadGame()
        {
            spawner.addAllCollideablesToList();
            this.Controls.Add(Coin.coinLabel);
            spawner.CreateEnemies(this);
            spawner.CreateGround(this);
            spawner.CreatePlayer(this);
            spawner.CreateTestCoin(this);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveEverything();
            foreach (var coin in coinList)
            {
                coin.CoinGrab();
            }
        }
        public void MoveEverything()
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                enemyList[i].MoveEnemyInDirection();
            }

            player.IfKeyDown();
        }
    }
}
