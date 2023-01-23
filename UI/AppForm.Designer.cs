namespace Proiect_Space_Invaders
{
    partial class AppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endPanel1 = new Proiect_Space_Invaders.UI.EndPanel();
            this.gamePanel1 = new Proiect_Space_Invaders.UI.GamePanel();
            this.main_Menu1 = new Proiect_Space_Invaders.UI.MenuPanel();
            this.SuspendLayout();
            // 
            // endPanel1
            // 
            this.endPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.endPanel1.game = null;
            this.endPanel1.gamePanel = null;
            this.endPanel1.Location = new System.Drawing.Point(901, 219);
            this.endPanel1.menuPanel = null;
            this.endPanel1.MinimumSize = new System.Drawing.Size(600, 600);
            this.endPanel1.Name = "endPanel1";
            this.endPanel1.Size = new System.Drawing.Size(600, 600);
            this.endPanel1.TabIndex = 2;
            this.endPanel1.Load += new System.EventHandler(this.endPanel1_Load);
            // 
            // gamePanel1
            // 
            this.gamePanel1.BackColor = System.Drawing.Color.Black;
            this.gamePanel1.game = null;
            this.gamePanel1.Location = new System.Drawing.Point(901, -12);
            this.gamePanel1.MinimumSize = new System.Drawing.Size(1000, 700);
            this.gamePanel1.Name = "gamePanel1";
            this.gamePanel1.Size = new System.Drawing.Size(1300, 900);
            this.gamePanel1.TabIndex = 1;
            this.gamePanel1.Load += new System.EventHandler(this.game1_Load);
            // 
            // main_Menu1
            // 
            this.main_Menu1.BackColor = System.Drawing.Color.Black;
            this.main_Menu1.endPanel = null;
            this.main_Menu1.ForeColor = System.Drawing.Color.White;
            this.main_Menu1.game = null;
            this.main_Menu1.gamePanel = null;
            this.main_Menu1.Location = new System.Drawing.Point(-9, -12);
            this.main_Menu1.MinimumSize = new System.Drawing.Size(1000, 700);
            this.main_Menu1.Name = "main_Menu1";
            this.main_Menu1.Size = new System.Drawing.Size(1300, 900);
            this.main_Menu1.TabIndex = 0;
            this.main_Menu1.Load += new System.EventHandler(this.main_Menu1_Load);
            // 
            // AppForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1282, 853);
            this.Controls.Add(this.endPanel1);
            this.Controls.Add(this.gamePanel1);
            this.Controls.Add(this.main_Menu1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Text = "Space Invaders - Jinariu Paul Alin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppForm_FormClosing);
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.MenuPanel main_Menu1;
        private UI.GamePanel gamePanel1;
        private UI.EndPanel endPanel1;
    }
}

