namespace Proiect_Space_Invaders.UI
{
    partial class GamePanel
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.shipSpeedLabel = new System.Windows.Forms.Label();
            this.bulletSpeedLabel = new System.Windows.Forms.Label();
            this.damageLabel = new System.Windows.Forms.Label();
            this.spendLabel = new System.Windows.Forms.Label();
            this.cooldownLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(569, 21);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(114, 31);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "SCORE: 0";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.Black;
            this.moneyLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.White;
            this.moneyLabel.Location = new System.Drawing.Point(200, 23);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(38, 31);
            this.moneyLabel.TabIndex = 1;
            this.moneyLabel.Text = "$0";
            // 
            // shipSpeedLabel
            // 
            this.shipSpeedLabel.AutoSize = true;
            this.shipSpeedLabel.BackColor = System.Drawing.Color.Black;
            this.shipSpeedLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.shipSpeedLabel.Location = new System.Drawing.Point(19, 71);
            this.shipSpeedLabel.Name = "shipSpeedLabel";
            this.shipSpeedLabel.Size = new System.Drawing.Size(154, 31);
            this.shipSpeedLabel.TabIndex = 2;
            this.shipSpeedLabel.Text = "Ship Speed: 4";
            this.shipSpeedLabel.Click += new System.EventHandler(this.shipSpeedLabel_Click);
            // 
            // bulletSpeedLabel
            // 
            this.bulletSpeedLabel.AutoSize = true;
            this.bulletSpeedLabel.BackColor = System.Drawing.Color.Black;
            this.bulletSpeedLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulletSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.bulletSpeedLabel.Location = new System.Drawing.Point(19, 102);
            this.bulletSpeedLabel.Name = "bulletSpeedLabel";
            this.bulletSpeedLabel.Size = new System.Drawing.Size(166, 31);
            this.bulletSpeedLabel.TabIndex = 3;
            this.bulletSpeedLabel.Text = "Bullet Speed: 8";
            this.bulletSpeedLabel.Click += new System.EventHandler(this.bulletSpeedLabel_Click);
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.BackColor = System.Drawing.Color.Black;
            this.damageLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageLabel.ForeColor = System.Drawing.Color.White;
            this.damageLabel.Location = new System.Drawing.Point(19, 164);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(123, 31);
            this.damageLabel.TabIndex = 4;
            this.damageLabel.Text = "Damage: 1";
            this.damageLabel.Click += new System.EventHandler(this.damageLabel_Click);
            // 
            // spendLabel
            // 
            this.spendLabel.AutoSize = true;
            this.spendLabel.BackColor = System.Drawing.Color.Black;
            this.spendLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spendLabel.ForeColor = System.Drawing.Color.White;
            this.spendLabel.Location = new System.Drawing.Point(21, 29);
            this.spendLabel.Name = "spendLabel";
            this.spendLabel.Size = new System.Drawing.Size(173, 23);
            this.spendLabel.TabIndex = 5;
            this.spendLabel.Text = "Click to spend money";
            // 
            // cooldownLabel
            // 
            this.cooldownLabel.AutoSize = true;
            this.cooldownLabel.BackColor = System.Drawing.Color.Black;
            this.cooldownLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cooldownLabel.ForeColor = System.Drawing.Color.White;
            this.cooldownLabel.Location = new System.Drawing.Point(19, 133);
            this.cooldownLabel.Name = "cooldownLabel";
            this.cooldownLabel.Size = new System.Drawing.Size(234, 31);
            this.cooldownLabel.TabIndex = 7;
            this.cooldownLabel.Text = "Bullet Cooldown: 100";
            this.cooldownLabel.Click += new System.EventHandler(this.cooldownLabel_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Black;
            this.healthLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(1149, 29);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(120, 31);
            this.healthLabel.TabIndex = 8;
            this.healthLabel.Text = "Health: 10";
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.cooldownLabel);
            this.Controls.Add(this.spendLabel);
            this.Controls.Add(this.damageLabel);
            this.Controls.Add(this.bulletSpeedLabel);
            this.Controls.Add(this.shipSpeedLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(1300, 900);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label shipSpeedLabel;
        private System.Windows.Forms.Label bulletSpeedLabel;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.Label spendLabel;
        private System.Windows.Forms.Label cooldownLabel;
        private System.Windows.Forms.Label healthLabel;
    }
}
