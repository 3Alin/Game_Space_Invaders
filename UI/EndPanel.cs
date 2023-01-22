using Proiect_Space_Invaders.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Space_Invaders.UI
{
    public partial class EndPanel : UserControl
    {

        public Game.Game game { get; set; }
        public MenuPanel menuPanel { get; set; }
        public GamePanel gamePanel { get; set; }

        public EndPanel()
        {
            InitializeComponent();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            game.initialise();
            game.run();
            errorLabel.Visible = true;
            Visible = false;
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            menuPanel.Visible = true;
            gamePanel.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (name.Length < 3 || name.Length > 20)
            {
                displayError("Must be between 3 - 20 characters");
                return;
            }
            foreach (char c in name)
                if (!(Char.IsLetter(c) || Char.IsNumber(c)))
                {
                    displayError("Must contain only letters and/or numbers");
                    return;
                }

            if (DataTools.dataAdd(name, int.Parse(scoreLabel.Text.Replace("YOUR SCORE: ", ""))))
                errorLabel.Visible = false;
            else
                displayError("Can't save: This person has a higher score\nthan the current one. Try another name?");
        }

        private void displayError(string message)
        {
            errorLabel.Text = message;
            errorLabel.Visible = true;
        }

        private void EndPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
                errorLabel.Text = "";
        }

        private void EndPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
