
namespace Springfield_Reactor_Melt_Down_Game
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reactorStableLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(28, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(389, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Springfield Reactor Controller";
            // 
            // reactor2Label
            // 
            this.reactor2Label.AutoSize = true;
            this.reactor2Label.Location = new System.Drawing.Point(299, 99);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(70, 17);
            this.reactor2Label.TabIndex = 1;
            this.reactor2Label.Text = "Reactor 2";
            // 
            // reactor1Label
            // 
            this.reactor1Label.AutoSize = true;
            this.reactor1Label.Location = new System.Drawing.Point(78, 99);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(70, 17);
            this.reactor1Label.TabIndex = 2;
            this.reactor1Label.Text = "Reactor 1";
            // 
            // stateLabel
            // 
            this.stateLabel.BackColor = System.Drawing.Color.Lime;
            this.stateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stateLabel.Location = new System.Drawing.Point(266, 116);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(151, 110);
            this.stateLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 110);
            this.label1.TabIndex = 4;
            // 
            // reactorStableLabel
            // 
            this.reactorStableLabel.BackColor = System.Drawing.SystemColors.Window;
            this.reactorStableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactorStableLabel.Location = new System.Drawing.Point(34, 390);
            this.reactorStableLabel.Name = "reactorStableLabel";
            this.reactorStableLabel.Size = new System.Drawing.Size(383, 35);
            this.reactorStableLabel.TabIndex = 5;
            this.reactorStableLabel.Text = "Stable";
            this.reactorStableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(150, 305);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 41);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(444, 489);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.reactorStableLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Springfield Reactor Meltdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reactorStableLabel;
        private System.Windows.Forms.Button startButton;
    }
}

