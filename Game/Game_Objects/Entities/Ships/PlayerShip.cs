using Proiect_Space_Invaders.Library;
using System.Drawing;
using System.Windows.Input;

namespace Proiect_Space_Invaders.Game
{
    public class PlayerShip : SpaceShip, IRenderedObj
    {
        public int score { get; set; } = 0;
        public int money { get; set; } = 0;

        public PlayerShip(ProjectileManager projectiles) : base(projectiles)
        {
            setPosition(Program.screenSize[0] / 2 - width / 2, Program.screenSize[1] - height * 2);
            health = 10;
            bullet_speed = -bullet_speed;
        }

        public void update(float dt)
        {
            if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left))
                move(-ship_speed, dt);
            else if (Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right))
                move(ship_speed, dt);
            else
                idle();

            if (Keyboard.IsKeyDown(Key.Space))
                doubleShoot(dt);
            else if (coolDownElapsedTime < shoot_cooldown)
                coolDownElapsedTime += dt;
        }

        public void paint(Graphics g)
        {
            if (currentState == state.left)
                sprite = AssetManager.playerShip[0];
            else if (currentState == state.half_left)
                sprite = AssetManager.playerShip[1];
            else if (currentState == state.half_right)
                sprite = AssetManager.playerShip[3];
            else if (currentState == state.right)
                sprite = AssetManager.playerShip[4];
            else
                sprite = AssetManager.playerShip[2];

            g.DrawImage(sprite, x - SPRITE_OFFSET_X, y - SPRITE_OFFSET_Y);
        }
    }
}
