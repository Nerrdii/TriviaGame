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
        DBIntermediary dbIntermediary = new DBIntermediary();
        BindingSource questionsBindingSource;
        List<Question> questions;

        int score;
        int questionCounter = 0;

        string Category { get; set; }
        string Username { get; set; }

        public PlayNow(string category, string username)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            Category = category;
            Username = username;
        }

        private void PlayNow_Load(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        /**
         * Get questions from database for chosen category and bind to form
         */
        private void LoadQuestions()
        {
            questions = dbIntermediary.GetQuestions(Category).ToList();
            try
            {
                questionsBindingSource = new BindingSource()
                {
                    DataSource = questions
                };

                // Bind question and answers to form
                questDisplayLabel.DataBindings.Add("Text", questionsBindingSource, "Text");
                answerButton1.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[0], "Text");
                answerButton2.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[1], "Text");
                answerButton3.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[2], "Text");
                answerButton4.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[3], "Text");
                RefreshAnswerBindings();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Make sure they chose an answer before going to next question
            if (!answerButton1.Checked && !answerButton2.Checked && !answerButton3.Checked && !answerButton4.Checked)
            {
                MessageBox.Show("Must select an option", "Error", MessageBoxButtons.OK);
                return;
            }

            // Get selected answer
            RadioButton selected = answersGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            // If they chose right answer, add to score based off difficulty of question
            if (selected.Text == GetCorrectAnswer().Text)
            {
                switch (((Question)questionsBindingSource.Current).Difficulty.Trim())
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

            // Go to next question
            questionsBindingSource.MoveNext();

            // Refresh answer options
            RefreshAnswerBindings();

            questionCounter++;
            
            // If they've reached the last question, show score and then go to high scores form
            if (questionCounter == questionsBindingSource.Count)
            {
                MessageBox.Show($"You scored {score} points", "Game Over", MessageBoxButtons.OK);

                dbIntermediary.AddScore(Username, score);

                Hide();
                HighScores highScores = new HighScores()
                {
                    MdiParent = MdiParent
                };
                highScores.Show();
            }

            selected.Checked = false;
        }

        /**
         * Removes and adds data binding again for answer radio buttons.
         * It's done this way because there's no easy way to bind to nested property of object
         * (i.e. question.Answers[0].Text)
         */
        private void RefreshAnswerBindings()
        {
            answerButton1.DataBindings.Remove(answerButton1.DataBindings["Text"]);
            answerButton1.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[0], "Text");

            answerButton2.DataBindings.Remove(answerButton2.DataBindings["Text"]);
            answerButton2.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[1], "Text");

            answerButton3.DataBindings.Remove(answerButton3.DataBindings["Text"]);
            answerButton3.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[2], "Text");

            answerButton4.DataBindings.Remove(answerButton4.DataBindings["Text"]);
            answerButton4.DataBindings.Add("Text", ((Question)questionsBindingSource.Current).Answers[3], "Text");
        }

        /**
         * Gets the correct answer so we can compare to the one they selected
         */
        private Answer GetCorrectAnswer()
        {
            return ((Question)questionsBindingSource.Current).Answers.First(r => r.IsCorrect);
        }

        private void quitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
