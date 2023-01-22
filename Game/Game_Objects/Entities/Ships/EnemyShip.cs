using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Space_Invaders.Game
{
    internal class EnemyShip : SpaceShip, IRenderedObj
    {
        Brush brush = new SolidBrush(Color.Red);
        private bool spawning = true;
        private const int MAX_IDLE_TIME = 2500;
        private float idleTime = new Random().Next(0, MAX_IDLE_TIME);
        private float targetX;
        private float targetY;

        public EnemyShip(ProjectileManager projectiles) : base(projectiles)
        {
            health = ShipsManager.ENEMY_HEALTH;
            Random rnd = new Random();
            targetX = rnd.Next((int)width, Program.screenSize[0] - (int)width);
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
                    return;
                }
                idleTime = new Random().Next(0, MAX_IDLE_TIME);
                targetX = new Random().Next((int)-width, Program.screenSize[0]);
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
            g.FillRectangle(brush, x, y, width, height);
        }
        
    }
}
