using System;
using System.Windows.Forms;

namespace Proiect_Space_Invaders.UI
{
    public partial class GamePanel : UserControl
    {
        public Game.Game game { get; set; } 

        public GamePanel()
        {
            InitializeComponent();
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer,
            true);
        }

       
        private void Game_Load(object sender, EventArgs e)
        {
        }

        private void shipSpeedLabel_Click(object sender, EventArgs e)
        {
            if (!purchase())
                return;
            game.getPlayer().ship_speed += 0.1f;
            refreshUI();
        }

        private void bulletSpeedLabel_Click(object sender, EventArgs e)
        {
            if (!purchase())
                return;
            game.getPlayer().bullet_speed -= 0.1f;
            refreshUI();
        }

        private void cooldownLabel_Click(object sender, EventArgs e)
        {
            if (!purchase() || game.getPlayer().shoot_cooldown < 11)
                return;
            game.getPlayer().shoot_cooldown -= 10;
            refreshUI();
        }

        private void damageLabel_Click(object sender, EventArgs e)
        {
            if (!purchase())
                return;
            game.getPlayer().damage += 1;
            refreshUI();
        }

        public bool purchase()
        {
            if (!game.running || game.getPlayer().money < 1)
                return false;

            game.getPlayer().money -= 1;
            return true;
        }
        public void refreshUI()
        {
            scoreLabel.Text = "SCORE: " + game.getPlayer().score;
            healthLabel.Text = "Health: " + game.getPlayer().health;
            moneyLabel.Text = "$" + game.getPlayer().money;
            shipSpeedLabel.Text = "Ship Speed: " + (int)(game.getPlayer().ship_speed * 10);
            bulletSpeedLabel.Text = "Bullet Speed: " + -(int)(game.getPlayer().bullet_speed * 10);
            cooldownLabel.Text = "Bullet Cooldown: " + game.getPlayer().shoot_cooldown / 10;
            damageLabel.Text = "Damage: " + game.getPlayer().damage;
        }
    }
}
