using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace Springfield_Reactor_Melt_Down_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertSound = new SoundPlayer(Properties.Resources.alert);
            alertSound.Play();//Hello World

            label1.BackColor = Color.Red;
            stateLabel.BackColor = Color.Red;

            this.BackColor = Color.White;
            reactorStableLabel.Text = "Reactor Meltdown";

            reactorStableLabel.BackColor = Color.Red;
            reactorStableLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            
            reactorStableLabel.BackColor = Color.White;
            reactorStableLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            reactorStableLabel.BackColor = Color.Red;
            reactorStableLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(1000);
            
            reactorStableLabel.BackColor = Color.White;
            reactorStableLabel.ForeColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

        }
    }
}
