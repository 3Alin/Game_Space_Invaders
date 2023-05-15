using Proiect_Space_Invaders.Library;
using System.Drawing;


namespace Proiect_Space_Invaders.Game
{
    public class ShipsManager : IRenderedObj
    {   
        public static int MAX_SHIPS;
        public static int ENEMY_HEALTH;
        public static int ENEMY_SPAWN_COOLDOWN;
        const int MILESTONE = 10;

        private float elapsedTime = ENEMY_SPAWN_COOLDOWN;
        private int lastMilestone = 0;
        private ProjectileManager projectileManager;
        public SpaceShip[] ship;

        public ShipsManager(ProjectileManager projectileManager)
        {
            MAX_SHIPS = 5;
            ENEMY_HEALTH = 2;
            ENEMY_SPAWN_COOLDOWN = 1000;
            this.projectileManager = projectileManager;
            this.ship = new SpaceShip[MAX_SHIPS];
            this.ship[0] = new PlayerShip(projectileManager);
            for (int i = 1; i < MAX_SHIPS; i++)
            {
                this.ship[i] = null;
            }
        }

        private void addEnemy(float dt)
        {
            if (elapsedTime < ENEMY_SPAWN_COOLDOWN)
            {
                elapsedTime += dt;
                return;
            }
            elapsedTime = 0;

            for (int i = 0; i < MAX_SHIPS; i++)
            {
                if (this.ship[i] == null)
                {
                    this.ship[i] = new EnemyShip(projectileManager);
                    return;
                }
            }
        }

        private void increaseDifficulty()
        {
            PlayerShip player = (PlayerShip)ship[0];
            if (player == null)
                return;
            if (player.score % MILESTONE != 0 || player.score == lastMilestone)
                return;

            lastMilestone = player.score;

            if (MAX_SHIPS < 50)
                growShipsVectorWith(3);
            if (ENEMY_SPAWN_COOLDOWN >= 25)
                ENEMY_SPAWN_COOLDOWN -= 25;

            ENEMY_HEALTH += 3;
            player.health += 1;
            UITools.refreshGamePanel("healthLabel", "Health: " + player.health);
            AssetManager.playSound("difficulty.wav");
        }

        private void growShipsVectorWith(int value)
        {
            MAX_SHIPS += value;
            SpaceShip[] tmp = new SpaceShip[MAX_SHIPS];
            for (int i = 0; i < ship.Length; i++)
            {
                tmp[i] = ship[i];
            }
            for (int i = ship.Length; i < MAX_SHIPS; i++)
            {
                tmp[i] = null;
            }
            ship = tmp;
        }

        public void update(float dt)
        {
            increaseDifficulty();
            addEnemy(dt);

            for (int i = 0; i < MAX_SHIPS; i++)
            {
                if (ship[i] != null)
                {
                    if (ship[i] is PlayerShip)
                    {
                        PlayerShip player = (PlayerShip)ship[i];
                        player.update(dt);
                    }
                    else if (ship[i] is EnemyShip)
                    {
                        EnemyShip enemy = (EnemyShip)ship[i];
                        enemy.update(dt);
                    }
                }
            }
        }
        public void paint(Graphics g)
        {
            for (int i = 0; i < MAX_SHIPS; i++)
            {
                if (ship[i] != null)
                {
                    if (ship[i] is PlayerShip)
                    {
                        PlayerShip player = (PlayerShip)ship[i];
                        player.paint(g);
                    }
                    else if (ship[i] is EnemyShip)
                    {
                        EnemyShip enemy = (EnemyShip)ship[i];
                        enemy.paint(g);
                    }
                }
            }
        }

    }
}
