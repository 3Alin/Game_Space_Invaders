using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Space_Invaders.Game
{
    internal class Background : IRenderedObj
    {
        private Brush brush = new SolidBrush(Color.Black);

        public void update(float dt)
        {
            throw new NotImplementedException();
        }

        public void paint(Graphics g)
        {
            g.FillRectangle(brush, 0, 0, Program.screenSize[0], Program.screenSize[1]);
        }
    }
}
