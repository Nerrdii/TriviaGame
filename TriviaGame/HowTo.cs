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
    public partial class HowTo : Form
    {
        public HowTo()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            
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
