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
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //instantiate back button
            this.Hide();
            Main backMain = new Main(); 
            backMain.MdiParent = this.MdiParent;
            backMain.Show();
            
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {

        }

        private void playNowButton_Click(object sender, EventArgs e)
        {
            //instantiate playnow button
            this.Hide();
            PlayNow myPlayNow = new PlayNow();
            myPlayNow.MdiParent = this.MdiParent;
            myPlayNow.Show();

        }
    }
}
