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
    public partial class PlayGame : Form
    {
        public PlayGame()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();

            Main backMain = new Main
            {
                MdiParent = MdiParent
            };

            backMain.Show();
        }

        private void playNowButton_Click(object sender, EventArgs e)
        {
            // Get chosen category
            var category = categoryGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            // Do validation to make sure they chose category and entered name
            if (category == null)
            {
                MessageBox.Show("Category must be chosen", "Error", MessageBoxButtons.OK);
                return;
            }

            if (namesTextBox.Text == "")
            {
                MessageBox.Show("You must enter a name", "Error", MessageBoxButtons.OK);
                return;
            }

            Hide();

            PlayNow myPlayNow = new PlayNow(category.Text, namesTextBox.Text)
            {
                MdiParent = MdiParent
            };

            myPlayNow.Show();
        }
    }
}
