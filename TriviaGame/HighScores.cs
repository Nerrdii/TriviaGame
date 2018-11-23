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

        private void HighScores_Load(object sender, EventArgs e)
        {
            DBIntermediary dbIntermediary = new DBIntermediary();
            scoreDataGridView.DataSource = dbIntermediary.Leaderboard();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();

            Main mainForm = new Main
            {
                MdiParent = MdiParent
            };

            mainForm.Show();
        }
    }
}
