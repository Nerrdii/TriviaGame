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
                BindingSource questionsBindingSource = new BindingSource
                {
                    DataSource = triviaDbIntermediary.GetQuestions(Category)
                };

                //((List<MultipleChoiceQuestion>)questionsBindingSource.DataSource).ForEach(q => q.Answers)

                questDisplayLabel.DataBindings.Add("Text", questionsBindingSource, "Question");
                answerButton1.DataBindings.Add("Text", ((MultipleChoiceQuestion) questionsBindingSource.Current).Answers[0], "Text");
                answerButton2.DataBindings.Add("Text", ((MultipleChoiceQuestion) questionsBindingSource.Current).Answers[1], "Text");
                answerButton3.DataBindings.Add("Text", ((MultipleChoiceQuestion) questionsBindingSource.Current).Answers[2], "Text");
                answerButton4.DataBindings.Add("Text", ((MultipleChoiceQuestion) questionsBindingSource.Current).Answers[3], "Text");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
