using System.Drawing;

namespace Proiect_Space_Invaders.Game
{
    internal interface IRenderedObj
    {
        void update(float dt);
        void paint(Graphics g);
    }
}
