using Proiect_Space_Invaders.Library;
using System.Drawing;


namespace Proiect_Space_Invaders.Game
{
    public class SpaceShip : GameObject
    {
        public int health { get; set; } = 2;
        public int damage { get; set; } = 1;
        public float ship_speed { get; set; } = 0.4f;
        public float bullet_speed { get; set; } = 0.8f;
        public int shoot_cooldown { get; set; } = 1000;

        private ProjectileManager projectiles;
        protected float coolDownElapsedTime;

        protected Bitmap sprite;
        protected enum state  { idle, half_left, left, half_right, right }
        protected state currentState = state.idle;
        private float animationElapsedTime;
        protected const int SPRITE_OFFSET_X = 20;
        protected const int SPRITE_OFFSET_Y = 30;


        public SpaceShip(ProjectileManager projectiles) 
        {
            this.projectiles = projectiles;
            coolDownElapsedTime = shoot_cooldown;
            animationElapsedTime = 0;
            width = 60;
            height = 60;
        }


        public void idle()
        {
            animationElapsedTime = 0;
            currentState = state.idle;
        }

        public void move(float speed, float dt)
        {
            const int CHANGE_TIME = 200;
            if (animationElapsedTime < CHANGE_TIME)
                animationElapsedTime += dt;

            if (speed > 0)
            {
                if (animationElapsedTime < CHANGE_TIME)
                    currentState = state.half_right;
                else if (currentState == state.left)
                    idle();
                else
                    currentState = state.right;
            }
            else
            {
                if (animationElapsedTime < CHANGE_TIME)
                    currentState = state.half_left;
                else if (currentState == state.right)
                    idle();
                else
                    currentState = state.left;
            }

            if (x + speed * dt < 0 || x + speed * dt > Program.screenSize[0] - width)
                return;
            x += speed * dt;
        }

        public void shoot(float dt)
        {
            if (coolDownElapsedTime > shoot_cooldown)
            {
                AssetManager.playSound("shoot1.wav");
                coolDownElapsedTime = 0;
                Projectile projectile = new Projectile(this, bullet_speed, x + sprite.Width / 2, y + 10);
                projectile.x -= projectile.width * 2;
                projectiles.addProjectile(projectile);
            }

            coolDownElapsedTime += dt;
        }

        public void doubleShoot(float dt)
        {
            if (coolDownElapsedTime >= shoot_cooldown)
            {
                AssetManager.playSound("shoot2.wav");
                coolDownElapsedTime = 0;
                Projectile projectile = new Projectile(this, bullet_speed, x + sprite.Width / 2 - 20, y);
                projectile.x -= projectile.width * 2;
                projectiles.addProjectile(projectile);
                projectile = new Projectile(this, bullet_speed, x + sprite.Width / 2 + 20, y);
                projectile.x -= projectile.width;
                projectiles.addProjectile(projectile);
            }

            coolDownElapsedTime += dt;
        }

        public void takeDamage(int dmg)
        {
            health -= dmg;
        }
    }
}
