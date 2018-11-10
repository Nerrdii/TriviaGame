using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataAccessClassLibrary.Models;

namespace DataAccessClassLibrary
{
    public class TriviaDbAccess
    {
        private SqlConnection triviaDBCon;
        private string triviaConnString = ConfigurationManager.ConnectionStrings["TriviaGame.Properties.Settings.Setting"].ConnectionString;

        public SqlConnection GetDBConnection()
        {
            if (triviaDBCon == null)
            {
                triviaDBCon = new SqlConnection(triviaConnString);
                
            }
            return triviaDBCon;
        }

        public void CloseDBConnection()
        {
            triviaDBCon.Close();
        }

        public void OpenDBConnection()
        {
            if (triviaDBCon.State == ConnectionState.Closed)
            {
                triviaDBCon.Open();
            }
        }

        public DataSet GenericQuery(string sqlQuery)
        {
            DataSet triviaDataSet = new DataSet();

            try
            {
                SqlDataAdapter trivAdapter = new SqlDataAdapter(sqlQuery, GetDBConnection());
                this.OpenDBConnection();
                trivAdapter.Fill(triviaDataSet);
                return triviaDataSet;
            }
            finally
            {
                this.CloseDBConnection();
            }
        }

        public void AddQuestionAndAnswers(MultipleChoiceQuestion question)
        {
            int questionId = AddQuestion(question);

            int correctAnswerId = AddAnswer(question.CorrectAnswer, questionId);
            AddAnswer(question.SecondAnswer, questionId);
            AddAnswer(question.ThirdAnswer, questionId);
            AddAnswer(question.FourthAnswer, questionId);

            SetCorrectAnswer(questionId, correctAnswerId);
        }

        private int AddQuestion(MultipleChoiceQuestion question)
        {
            int categoryId = GetCategoryID(question.Category);

            string sqlQuery = "INSERT INTO Question (QuestionText, CategoryID, Difficulty) OUTPUT INSERTED.ID VALUES (@Question, @CategoryID, @Difficulty)";

            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            command.Parameters.AddWithValue("Question", question.Question);
            command.Parameters.AddWithValue("CategoryID", categoryId);
            command.Parameters.AddWithValue("Difficulty", question.Difficulty);

            OpenDBConnection();

            int questionId = (int)command.ExecuteScalar();

            CloseDBConnection();

            return questionId;
        }

        private int GetCategoryID(string category)
        {
            string sqlQuery = "SELECT ID FROM Category WHERE Category = @Category";

            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            command.Parameters.AddWithValue("Category", category);

            OpenDBConnection();

            int categoryId = (int)command.ExecuteScalar();

            CloseDBConnection();

            return categoryId;
        }

        private int AddAnswer(string answerText, int questionId)
        {
            string sqlQuery = "INSERT INTO [Option] (OptionText) OUTPUT INSERTED.ID VALUES (@Answer)";

            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            command.Parameters.AddWithValue("Answer", answerText);

            OpenDBConnection();

            int answerId = (int)command.ExecuteScalar();

            AddQuestionAnswer(questionId, answerId);

            CloseDBConnection();

            return answerId;
        }

        private void AddQuestionAnswer(int questionId, int answerId)
        {
            string sqlQuery = "INSERT INTO Question_Option (QuestionID, OptionID) VALUES (@QuestionID, @OptionID)";

            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            command.Parameters.AddWithValue("QuestionID", questionId);
            command.Parameters.AddWithValue("OptionID", answerId);

            OpenDBConnection();

            command.ExecuteScalar();

            CloseDBConnection();
        }

        private void SetCorrectAnswer(int questionId, int correctAnswerId)
        {
            string sqlQuery = "UPDATE Question SET Answer = @Answer WHERE ID = @QuestionID";

            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            command.Parameters.AddWithValue("Answer", correctAnswerId);
            command.Parameters.AddWithValue("QuestionID", questionId);

            OpenDBConnection();

            command.ExecuteScalar();

            CloseDBConnection();
        }

    }
}
