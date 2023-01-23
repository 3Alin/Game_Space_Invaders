using System;
using System.Drawing;


namespace Proiect_Space_Invaders.Game
{
    internal class Background : IRenderedObj
    {
        private Brush background = new SolidBrush(Color.Black);

        public void update(float dt)
        {
            throw new NotImplementedException();
        }

        public void paint(Graphics g)
        {
            g.FillRectangle(background, 0, 0, Program.screenSize[0], Program.screenSize[1]);
        }
    }
}
