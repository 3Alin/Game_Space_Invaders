using Proiect_Space_Invaders.Library;
using System;
using System.Windows.Forms;

namespace Proiect_Space_Invaders.UI
{
    public partial class MenuPanel : UserControl
    {
        public Game.Game game { get; set; }
        public GamePanel gamePanel { get; set; }
        public EndPanel endPanel { get; set; }

        public MenuPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            game.initialise();
            game.run();
            gamePanel.Visible = true;
            endPanel.Visible = false;
            Visible = false;
        }

        private void MenuPanel_Load(object sender, EventArgs e)
        {

        }

        public void endGame()
        {
            endPanel.Visible = true;
        }

        private void MenuPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible && DataTools.getScoreData() != null)
                scoresBox.Text = 
                    Environment.NewLine + Environment.NewLine + '\t' +
                    DataTools.dataToString(DataTools.getSortedScoreData()).Replace("\n", Environment.NewLine + '\t');
        }

        private void flickerBox_CheckedChanged(object sender, EventArgs e)
        {
            game.flicker = flickerBox.Checked;
        }

        private void soundBox_CheckedChanged(object sender, EventArgs e)
        {
            AssetManager.muteSound = soundBox.Checked;
        }
    }
}
