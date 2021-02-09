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

namespace Play_Game
{
    public partial class playGame : Form
    {
        public playGame()
        {
            InitializeComponent();
            backButton.Hide();
            countDownLabel.Hide();
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer beep = new SoundPlayer(Properties.Resources.Beep);
            SoundPlayer go = new SoundPlayer(Properties.Resources.Go);

            countDownLabel.Show();
            playButton.Hide();
            settingsButton.Hide();
            quitButton.Hide();
            creditButton.Hide();
            
            countDownLabel.BackColor = Color.Black;

            beep.Play();
            countDownLabel.Text = "3";
            Refresh();
            Thread.Sleep(1000);

            beep.Play();
            countDownLabel.Text = "2";
            Refresh();
            Thread.Sleep(1000);

            beep.Play();
            countDownLabel.Text = "1";
            Refresh();
            Thread.Sleep(1000);

            countDownLabel.Text = "Starting Game";
            countDownLabel.BackColor = Color.Green;
            go.Play();
            Refresh();
            Thread.Sleep(1000);

            countDownLabel.Text = "";
            countDownLabel.Hide();
            Refresh();

            quitButton.Show();
            playButton.Show();
            settingsButton.Show();
            creditButton.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Select = new SoundPlayer(Properties.Resources.Menu_Select);
            Select.Play();

            Application.Exit();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Select = new SoundPlayer(Properties.Resources.Menu_Select);
            Select.Play();

            quitButton.Hide();
            playButton.Hide();
            settingsButton.Hide();
            creditButton.Hide();

            backButton.Show();

            settingsText.Text = "Theres nothing here :)";
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Select = new SoundPlayer(Properties.Resources.Menu_Select);
            Select.Play();
            
            quitButton.Show();
            playButton.Show();
            settingsButton.Show();
            creditButton.Show();
           
            settingsText.Text = "";
            creditLabel.Text = "";
            creditLabel2.Text = "";

            backButton.Hide();
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Select = new SoundPlayer(Properties.Resources.Menu_Select);
            Select.Play();

            quitButton.Hide();
            playButton.Hide();
            settingsButton.Hide();
            creditButton.Hide();
           
            backButton.Show();
          
            creditButton.ForeColor = Color.White;

            creditLabel.Text = "Made By Hunter Hansen";
            creditLabel2.Text = "Artist Is Unkown";
        }

        private void playGame_Load(object sender, EventArgs e)
        {

        }
    }
}
