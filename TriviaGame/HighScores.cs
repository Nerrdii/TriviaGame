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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void howTBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main backMain = new Main();
            backMain.MdiParent = this.MdiParent;
            backMain.Show();
            //this.Close();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            TriviaDbIntermediary inst = new TriviaDbIntermediary();
            scoreDataGridView.DataSource = inst.Leaderboard();
        }
    }
}
