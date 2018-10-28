using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartGame sG = new StartGame();           
            sG.Show();

        }

        private void howToButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions howTo = new Instructions();
            howTo.Show();
        }

        private void hiScoresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HighScores hScores = new HighScores();
            hScores.Show();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameOptions gOpt = new GameOptions();
            gOpt.Show();
        }
    }
}
