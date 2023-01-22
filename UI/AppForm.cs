using Proiect_Space_Invaders.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Space_Invaders
{
    public partial class AppForm : Form
    {

        private Game.Game game;


        public AppForm()
        {
            InitializeComponent();
            game = new Game.Game(main_Menu1, gamePanel1, endPanel1);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
             
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        private void main_Menu1_Load(object sender, EventArgs e)
        {
            gamePanel1.Location = main_Menu1.Location;
            main_Menu1.game = game;
            main_Menu1.gamePanel = gamePanel1;
            main_Menu1.endPanel = endPanel1;
        }
       
        private void game1_Load(object sender, EventArgs e)
        {
            gamePanel1.Visible = false;
            gamePanel1.game = game;
        }

        private void endPanel1_Load(object sender, EventArgs e)
        {
            endPanel1.Visible = false;
            endPanel1.Location = new Point(
                main_Menu1.Location.X + main_Menu1.Width / 2 - endPanel1.Width / 2,
                main_Menu1.Location.Y + main_Menu1.Height / 2 - endPanel1.Height / 2);
            endPanel1.game = game;
            endPanel1.menuPanel = main_Menu1;
            endPanel1.gamePanel = gamePanel1;
        }

    }
}
