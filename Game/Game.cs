using Proiect_Space_Invaders.Library;
using Proiect_Space_Invaders.UI;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Proiect_Space_Invaders.Game
{
    public class Game
    {
        private Background background;
        private ProjectileManager projectileManager;
        private ShipsManager shipsManager;

        public MenuPanel menuPanel;
        public GamePanel gamePanel;
        public EndPanel endPanel;

        private static Bitmap frame = new Bitmap(Program.screenSize[0], Program.screenSize[1]);
        private Graphics gr = Graphics.FromImage(frame);
        public bool flicker { get; set; }
        public bool running { get; set; }


        public Game(MenuPanel menuPanel , GamePanel gamePanel, EndPanel endPanel) 
        {
            AssetManager.loadAssets();
            UITools.game = this;
            this.menuPanel = menuPanel;
            this.gamePanel = gamePanel;  
            this.endPanel = endPanel;
            this.flicker = true;
        }

        public void initialise()
        {
            background = new Background();
            projectileManager = new ProjectileManager(this);
            shipsManager = new ShipsManager(projectileManager);

            projectileManager.shipsManager = shipsManager;
            running = false;
            gamePanel.refreshUI();
        }

        public void update(float dt)
        {
            projectileManager.update(dt);
            shipsManager.update(dt);
        }

        public void paint(Graphics g)
        {
            if (flicker)
            {
                background.paint(g);
                projectileManager.paint(g);
                shipsManager.paint(g);
                Thread.Sleep(1);
            }
            else
            {
                background.paint(gr);
                projectileManager.paint(gr);
                shipsManager.paint(gr);
                g.DrawImage(frame, 0, 0);
            }
        }

        public void run()
        {
            running = true;
            Thread th = new Thread(t => gameLoop());
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void gameLoop()
        {
            Stopwatch watch = new Stopwatch();
            Graphics graphics = gamePanel.CreateGraphics();

            while (running)
            {
                float dt = watch.ElapsedMilliseconds;
                watch.Restart();
                update(dt);
                paint(graphics);
            }

            menuPanel.Invoke(new MethodInvoker(delegate () {
                menuPanel.endGame();
            }));
        }

        public PlayerShip getPlayer()
        {
            return (PlayerShip)shipsManager.ship[0];
        }
    }
}
