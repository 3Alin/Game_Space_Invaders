﻿using Proiect_Space_Invaders.Library;
using Proiect_Space_Invaders.UI;
using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public bool running { get; set; }

        public Game(MenuPanel menuPanel , GamePanel gamePanel, EndPanel endPanel) 
        {
            UITools.game = this;
            this.menuPanel = menuPanel;
            this.gamePanel = gamePanel;  
            this.endPanel = endPanel;  
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
            background.paint(g);
            projectileManager.paint(g);
            shipsManager.paint(g);
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
                Thread.Sleep(1);
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
