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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayGame sG = new PlayGame();
            sG.MdiParent = this.MdiParent;                
            sG.Show();

        }

        private void howToButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HowTo howTo = new HowTo();
            howTo.MdiParent = this.MdiParent;
            howTo.Show();
        }

        private void hiScoresButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HighScores hScores = new HighScores();
            hScores.MdiParent = this.MdiParent;
            hScores.Show();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameOptions gOpt = new GameOptions();
            gOpt.MdiParent = this.MdiParent;
            gOpt.Show();
        }
    }
}
