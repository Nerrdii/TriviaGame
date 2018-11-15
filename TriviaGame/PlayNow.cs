using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessClassLibrary.Models;

namespace TriviaGame
{
    public partial class PlayNow : Form
    {
        TriviaDbIntermediary triviaDbIntermediary = new TriviaDbIntermediary();

        string Category { get; set; }

        public PlayNow(string category)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            Category = category;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void PlayNow_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            try
            {
                BindingSource bindingSourceQuestions = new BindingSource();
                bindingSourceQuestions.DataSource = triviaDbIntermediary.GetQuestions(Category);

                questDisplayLabel.DataBindings.Add("Text", bindingSourceQuestions, "Question");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
