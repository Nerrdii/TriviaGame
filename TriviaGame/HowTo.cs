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
    public partial class HowTo : Form
    {
        public HowTo()
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
        }

        private void fullButton_Click(object sender, EventArgs e)
        {
            howtoLabeltext.Text = "Just a place holder until real instructions are put in. So blah, blah blah and Maybe you're not sitting pretty with a Best Actor Oscar award, but you can win the Movie Buff Bragger title when you beat your friends and family at Movies Trivia game night!  Your family and friends will try to distract you with buttery popcorn, fizzy drinks and sugary concoctions, but you stay true to that movie brain of yours!  And when you need a short break, stand tall and tell em', I'LL BE BACK!.  That's right, they'll be quivering as you exit the room.";
        }

        private void quickButton_Click(object sender, EventArgs e)
        {
            howtoLabeltext.Text = "Man, stop being silly you know how to play a trivia game; Just Play!";
        }
    }
}
