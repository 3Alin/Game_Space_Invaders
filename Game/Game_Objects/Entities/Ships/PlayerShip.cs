using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proiect_Space_Invaders.Game
{
    public class PlayerShip : SpaceShip, IRenderedObj
    {
        Brush brush = new SolidBrush(Color.White);
        public int score { get; set; } = 0;
        public int money { get; set; } = 0;

        public PlayerShip(ProjectileManager projectiles) : base(projectiles)
        {
            setPosition(Program.screenSize[0] / 2 - width / 2, Program.screenSize[1] - height * 2);
            health = 3;
            bullet_speed = -bullet_speed;
        }

        public void update(float dt)
        {
            if (Keyboard.IsKeyDown(Key.A) || Keyboard.IsKeyDown(Key.Left))
                move(-ship_speed, dt);
            else if (Keyboard.IsKeyDown(Key.D) || Keyboard.IsKeyDown(Key.Right))
                move(ship_speed, dt);
            else
                idle(dt);

            if (Keyboard.IsKeyDown(Key.Space))
                shoot(dt);
            else if (elapsedTime < shoot_cooldown)
                elapsedTime += dt;
                
            
        }

        public void paint(Graphics g)
        {
            g.FillRectangle(brush, x, y, width, height);
        }
    }
}
