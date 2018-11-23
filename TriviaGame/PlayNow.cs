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
        BindingSource questionsBindingSource;
        List<MultipleChoiceQuestion> questions;

        int score;
        int questionCounter = 0;

        string Category { get; set; }

        public PlayNow(string category)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            Category = category;
        }

        private void PlayNow_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            questions = triviaDbIntermediary.GetQuestions(Category).ToList();
            try
            {
                questionsBindingSource = new BindingSource()
                {
                    DataSource = questions
                };

                questDisplayLabel.DataBindings.Add("Text", questionsBindingSource, "Question");
                answerButton1.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[0], "Text");
                answerButton2.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[1], "Text");
                answerButton3.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[2], "Text");
                answerButton4.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[3], "Text");
                RefreshAnswerBindings();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!answerButton1.Checked && !answerButton2.Checked && !answerButton3.Checked && !answerButton4.Checked)
            {
                MessageBox.Show("Must select an option", "Error", MessageBoxButtons.OK);
                return;
            }

            RadioButton selected = answersGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (selected.Text == GetCorrectAnswer().Text)
            {
                switch (((MultipleChoiceQuestion)questionsBindingSource.Current).Difficulty.Trim())
                {
                    case "Easy":
                        score += 1;
                        break;
                    case "Medium":
                        score += 3;
                        break;
                    case "Hard":
                        score += 5;
                        break;
                }
            }

            questionsBindingSource.MoveNext();

            RefreshAnswerBindings();

            questionCounter++;

            if (questionCounter == questionsBindingSource.Count)
            {
                MessageBox.Show($"You scored {score} points", "Game Over", MessageBoxButtons.OK);

                triviaDbIntermediary.AddScore("test", score);

                this.Hide();
                HighScores highScores = new HighScores()
                {
                    MdiParent = this.MdiParent
                };
                highScores.Show();
            }

            selected.Checked = false;
        }

        private void RefreshAnswerBindings()
        {
            answerButton1.DataBindings.Remove(answerButton1.DataBindings["Text"]);
            answerButton1.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[0], "Text");

            answerButton2.DataBindings.Remove(answerButton2.DataBindings["Text"]);
            answerButton2.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[1], "Text");

            answerButton3.DataBindings.Remove(answerButton3.DataBindings["Text"]);
            answerButton3.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[2], "Text");

            answerButton4.DataBindings.Remove(answerButton4.DataBindings["Text"]);
            answerButton4.DataBindings.Add("Text", ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers[3], "Text");
        }

        private Answer GetCorrectAnswer()
        {
            return ((MultipleChoiceQuestion)questionsBindingSource.Current).Answers.First(r => r.IsCorrect);
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
