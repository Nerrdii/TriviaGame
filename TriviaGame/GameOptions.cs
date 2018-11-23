using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccessClassLibrary.Models;

namespace TriviaGame
{
    public partial class GameOptions : Form
    {
        RadioButton category;
        RadioButton difficulty;

        public GameOptions()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Get the checked radio buttons for category and difficulty
            category = categoryGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            difficulty = difficultyGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            // Do validation to make sure everything is filled out
            if (category == null)
            {
                MessageBox.Show("Category must be chosen", "Error", MessageBoxButtons.OK);
                return;
            }

            if (difficulty == null)
            {
                MessageBox.Show("Difficulty must be chosen", "Error", MessageBoxButtons.OK);
                return;
            }

            if (questionTextBox.Text == "")
            {
                MessageBox.Show("Question must be provided", "Error", MessageBoxButtons.OK);
                return;
            }

            if (correctAnsTextBox.Text == "" || SecAnsTextBox.Text == "" || thirdAnsTextBox.Text == "" || fourthAnsTextBox.Text == "")
            {
                MessageBox.Show("All answers must be provided", "Error", MessageBoxButtons.OK);
                return;
            }

            // Create question from input boxed and add answers to it
            Question question = new Question
            {
                Text = questionTextBox.Text,
                Category = category.Text,
                Difficulty = difficulty.Text,
                Answers = new List<Answer>()
            };
            question.Answers.Add(new Answer(correctAnsTextBox.Text, true));
            question.Answers.Add(new Answer(SecAnsTextBox.Text));
            question.Answers.Add(new Answer(thirdAnsTextBox.Text));
            question.Answers.Add(new Answer(fourthAnsTextBox.Text));

            DBIntermediary triviaDbIntermediary = new DBIntermediary();

            // Add question to database
            triviaDbIntermediary.AddQuestionWithAnswers(question);

            MessageBox.Show("Question successfully added!", "Success", MessageBoxButtons.OK);

            ResetForm();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            category = categoryGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            difficulty = difficultyGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            ResetForm();
        }

        // Clear out all the input boxes and radio buttons
        private void ResetForm()
        {
            questionTextBox.Clear();
            correctAnsTextBox.Clear();
            SecAnsTextBox.Clear();
            thirdAnsTextBox.Clear();
            fourthAnsTextBox.Clear();

            if (category != null)
            {
                category.Checked = false;
            }

            if (difficulty != null)
            {
                difficulty.Checked = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();

            Main mainForm = new Main
            {
                MdiParent = MdiParent
            };

            mainForm.Show();
        }
    }
}
