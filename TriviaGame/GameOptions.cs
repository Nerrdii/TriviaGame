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

        private void optBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main backMain = new Main();
            backMain.MdiParent = this.MdiParent;
            backMain.Show();
            //this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            category = categoryGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            difficulty = difficultyGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

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

            MultipleChoiceQuestion question = new MultipleChoiceQuestion();
            question.Question = questionTextBox.Text;
            question.CorrectAnswer = correctAnsTextBox.Text;
            question.SecondAnswer = SecAnsTextBox.Text;
            question.ThirdAnswer = thirdAnsTextBox.Text;
            question.FourthAnswer = fourthAnsTextBox.Text;
            question.Category = category.Text;
            question.Difficulty = difficulty.Text;

            DataAccessClassLibrary.TriviaDbAccess dataAccessClass = new DataAccessClassLibrary.TriviaDbAccess();

            dataAccessClass.AddQuestionAndAnswers(question);

            MessageBox.Show("Question successfully added!", "Success", MessageBoxButtons.OK);

            ResetForm();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            category = categoryGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            difficulty = difficultyGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            ResetForm();
        }

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
    }
}
