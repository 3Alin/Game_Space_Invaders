using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Space_Invaders.Game
{
    public abstract class GameObject
    {
        public float x { get; set; }
        public float y { get; set; }
        public float width { get; set; }
        public float height { get; set; }


        public GameObject()
        { 
            x = 0; y = 0;
            width = 0; height = 0;   
        }

        public void setPosition(float x, float y)
        {
            this.x = x;
            this.y = y; 
        }
    }
}
