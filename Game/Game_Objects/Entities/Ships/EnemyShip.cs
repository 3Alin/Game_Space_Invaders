using Proiect_Space_Invaders.Library;
using System;
using System.Drawing;


namespace Proiect_Space_Invaders.Game
{
    internal class EnemyShip : SpaceShip, IRenderedObj
    {
        private bool spawning = true;
        private const int MAX_IDLE_TIME = 2500;
        private float idleTime = new Random().Next(0, MAX_IDLE_TIME);
        private float targetX;
        private float targetY;

        public EnemyShip(ProjectileManager projectiles) : base(projectiles)
        {
            health = ShipsManager.ENEMY_HEALTH;
            Random rnd = new Random();
            targetX = rnd.Next(0, Program.screenSize[0] - (int)width);
            targetY = rnd.Next(0, Program.screenSize[1] / 2);
            x = targetX;
            y = -height;
        }

        private void spawn(float dt)
        {
            if (!spawning)
                return;

            if (y < targetY)
                y += ship_speed * 2 * dt;
            else
                spawning = false;
        }

        private void roam(float dt)
        {
            if (spawning)
                return;

            if (x >= targetX - width && x <= targetX + width)
            {
                if (idleTime > 0)
                {
                    idleTime -= dt;
                    idle();
                    return;
                }
                idleTime = new Random().Next(0, MAX_IDLE_TIME);
                targetX = new Random().Next(0, (int)(Program.screenSize[0] - width));
            }

            if (x > targetX)
                move(-ship_speed, dt);
         
            else if (x < targetX)
                move(ship_speed, dt);
        }

        public void update(float dt)
        {
            spawn(dt);
            roam(dt);
            shoot(dt);
        }

        public void paint(Graphics g)
        {
            if (currentState == state.left)
                sprite = AssetManager.enemyShip[0];
            else if (currentState == state.half_left)
                sprite = AssetManager.enemyShip[1];
            else if (currentState == state.half_right)
                sprite = AssetManager.enemyShip[3];
            else if (currentState == state.right)
                sprite = AssetManager.enemyShip[4];
            else
                sprite = AssetManager.enemyShip[2];

            g.DrawImage(sprite, x - SPRITE_OFFSET_X, y - SPRITE_OFFSET_Y);
        }
        
    }
}
