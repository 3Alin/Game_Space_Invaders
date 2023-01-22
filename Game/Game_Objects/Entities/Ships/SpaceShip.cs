using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proiect_Space_Invaders.Game
{
    public class SpaceShip : GameObject
    {
        public int health { get; set; } = 2;
        public int damage { get; set; } = 1;
        public float ship_speed { get; set; } = 0.4f;
        public float bullet_speed { get; set; } = 0.8f;
        public int shoot_cooldown { get; set; } = 1000;

        ProjectileManager projectiles;
        public float elapsedTime;
        public enum state  { idle, left, right }
        public state currentState = state.idle;

        public SpaceShip(ProjectileManager projectiles) 
        {
            this.projectiles = projectiles;
            elapsedTime = shoot_cooldown;
            width = 60;
            height = 60;
        }


        public void idle(float dt)
        {
            currentState = state.idle;
        }

        public void move(float speed, float dt)
        {
            if (speed > 0)
                currentState = state.right;
            else
                currentState = state.left;

            if (x + speed * dt < -width || x + speed * dt > Program.screenSize[0])
                speed = 0;

            x += speed * dt;
        }

        public void shoot(float dt)
        {
            if (elapsedTime > shoot_cooldown)
            {
                elapsedTime = 0;
                Projectile projectile = new Projectile(this, bullet_speed, x + width / 2, y + 10);
                projectiles.addProjectile(projectile);
            }

            elapsedTime += dt;
        }

        public void takeDamage(int dmg)
        {
            health -= dmg;
        }
    }
}
