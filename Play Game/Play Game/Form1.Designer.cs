
namespace Play_Game
{
    partial class playGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playGame));
            this.playButton = new System.Windows.Forms.Button();
            this.countDownLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.settingsText = new System.Windows.Forms.Label();
            this.creditButton = new System.Windows.Forms.Button();
            this.creditLabel = new System.Windows.Forms.Label();
            this.creditLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Transparent;
            this.playButton.Location = new System.Drawing.Point(599, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(189, 96);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // countDownLabel
            // 
            this.countDownLabel.BackColor = System.Drawing.Color.Black;
            this.countDownLabel.ForeColor = System.Drawing.Color.White;
            this.countDownLabel.Location = new System.Drawing.Point(-2, -3);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(807, 463);
            this.countDownLabel.TabIndex = 1;
            this.countDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsButton.Location = new System.Drawing.Point(599, 114);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(189, 96);
            this.settingsButton.TabIndex = 2;
            this.settingsButton.Text = "Setting";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quitButton.Location = new System.Drawing.Point(599, 318);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(189, 83);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Black;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(12, 407);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 31);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // settingsText
            // 
            this.settingsText.AutoSize = true;
            this.settingsText.BackColor = System.Drawing.Color.Transparent;
            this.settingsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsText.ForeColor = System.Drawing.Color.Transparent;
            this.settingsText.Location = new System.Drawing.Point(329, 216);
            this.settingsText.Name = "settingsText";
            this.settingsText.Size = new System.Drawing.Size(0, 29);
            this.settingsText.TabIndex = 5;
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.creditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.creditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditButton.ForeColor = System.Drawing.Color.White;
            this.creditButton.Location = new System.Drawing.Point(599, 216);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(189, 96);
            this.creditButton.TabIndex = 6;
            this.creditButton.Text = "Credits";
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.White;
            this.creditLabel.Location = new System.Drawing.Point(329, 216);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(0, 29);
            this.creditLabel.TabIndex = 7;
            // 
            // creditLabel2
            // 
            this.creditLabel2.AutoSize = true;
            this.creditLabel2.BackColor = System.Drawing.Color.Transparent;
            this.creditLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel2.ForeColor = System.Drawing.Color.White;
            this.creditLabel2.Location = new System.Drawing.Point(331, 260);
            this.creditLabel2.Name = "creditLabel2";
            this.creditLabel2.Size = new System.Drawing.Size(0, 29);
            this.creditLabel2.TabIndex = 8;
            // 
            // playGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Play_Game.Properties.Resources.Valheim_Moder_Boss;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.creditLabel2);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.settingsText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.countDownLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "playGame";
            this.Text = "Play Cool Game";
            this.Load += new System.EventHandler(this.playGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label settingsText;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label creditLabel2;
    }
}

