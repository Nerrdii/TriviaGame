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
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 100);
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate Play Game
            Main myMain = new Main();
            myMain.MdiParent = this;
            myMain.Show();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instantiate the about box
            AboutGroupTwo myAbout = new AboutGroupTwo();
            myAbout.MdiParent = this;
            myAbout.Show();
        }
    }
}
