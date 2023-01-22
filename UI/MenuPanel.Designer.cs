namespace Proiect_Space_Invaders.UI
{
    partial class MenuPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.scoresBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(261, 635);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 53);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // scoresBox
            // 
            this.scoresBox.Location = new System.Drawing.Point(752, 133);
            this.scoresBox.Multiline = true;
            this.scoresBox.Name = "scoresBox";
            this.scoresBox.ReadOnly = true;
            this.scoresBox.Size = new System.Drawing.Size(432, 659);
            this.scoresBox.TabIndex = 1;
            this.scoresBox.TabStop = false;
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.scoresBox);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(1300, 900);
            this.Load += new System.EventHandler(this.MenuPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.MenuPanel_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox scoresBox;
    }
}
