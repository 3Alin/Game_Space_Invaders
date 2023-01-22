
using System;
using System.Drawing;


namespace Proiect_Space_Invaders.Game
{
    public class Projectile : GameObject, IRenderedObj
    {
        Brush brush = new SolidBrush(Color.White);
        public SpaceShip owner;
        public float speed;

        public Projectile(SpaceShip owner, float speed, float x, float y) 
        {
            width = 20;
            height = 20;
            this.owner = owner;
            this.speed = speed;
            this.x = x; this.y = y;
        }

        public void update(float dt)
        {
            y += speed * dt;
        }

        public void paint(Graphics g)
        {
            g.FillRectangle(brush, x - width / 2, y - height / 2, width, height);
        }
    }
}
