﻿using System;
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
        }

        private void howTBackButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Main backMain = new Main();
            backMain.Show();
            this.Close();
        }
    }
}
