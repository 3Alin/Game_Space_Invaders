using Proiect_Space_Invaders.Library;
using System.Drawing;


namespace Proiect_Space_Invaders.Game
{
    public class ProjectileManager : IRenderedObj
    {
        public static readonly int MAX_PROJECTILES = 200;
        public Projectile[] projectile = new Projectile[MAX_PROJECTILES];

        public Game game;
        public ShipsManager shipsManager { get; set; }

        public ProjectileManager(Game game)
        {
            this.game = game;
            for (int i = 0; i < MAX_PROJECTILES; i++)
            {
                this.projectile[i] = null;
            }
        }

        public void addProjectile(Projectile projectile)
        {
            for (int i = 0; i < MAX_PROJECTILES; i++) 
            {
                if (this.projectile[i] == null)
                {
                    this.projectile[i] = projectile;
                    return;
                }
            }
        }

        private void checkCollision(int i)
        {
            for (int j = 0; j < ShipsManager.MAX_SHIPS; j++)
            {
                if (projectile[i] == null)
                    return;
                if (shipsManager.ship[j] == null)
                    continue;

                if (Collision.isColliding(shipsManager.ship[j], projectile[i]))
                {
                    if (shipsManager.ship[j].GetType() == projectile[i].owner.GetType())
                        return;

                    shipsManager.ship[j].takeDamage(projectile[i].owner.damage);
                    if (shipsManager.ship[j] is PlayerShip)
                    {
                        AssetManager.playSound("damaged.wav");
                        UITools.refreshGamePanel("healthLabel", "Health: " + game.getPlayer().health);
                    }

                    if (shipsManager.ship[j].health <= 0)
                    {
                        AssetManager.playSound("destroyed.wav");
                        if (shipsManager.ship[j] is PlayerShip)
                        {
                            UITools.refreshEndPanel("scoreLabel", "YOUR SCORE: " + game.getPlayer().score);
                            playerData highScore = DataTools.getHighscore();
                            UITools.refreshEndPanel("hiLabel", "HIGHSCORE: " + highScore.score + " by " + highScore.name);
                            game.running = false;
                        }
                        else if (game.getPlayer() != null)
                        {
                            game.getPlayer().score++;
                            game.getPlayer().money++;
                            UITools.refreshGamePanel("scoreLabel", "SCORE: " + game.getPlayer().score);
                            UITools.refreshGamePanel("moneyLabel", "$" + game.getPlayer().money);
                        }
                        shipsManager.ship[j] = null;
                    }
                    projectile[i] = null;
                }
            }
        }

        private void isOutOfRender(int i)
        {
            if (projectile[i] == null)
                return;
            if (projectile[i].y > Program.screenSize[1] || projectile[i].y < 0)
                projectile[i] = null;
        }

        public void update(float dt)
        {
            for (int i = 0; i < MAX_PROJECTILES; i++)
            {
                if (projectile[i] != null)
                {
                    projectile[i].update(dt);
                    checkCollision(i);
                    isOutOfRender(i);
                }
            }
        }

        public void paint(Graphics g)
        {
            for (int i = 0; i < MAX_PROJECTILES; i++)
            {
                if (projectile[i] != null)
                    projectile[i].paint(g);
            }
        }
    }
}
