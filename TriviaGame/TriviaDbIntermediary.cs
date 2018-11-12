using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccessClassLibrary;
using DataAccessClassLibrary.Models;


namespace TriviaGame
{
    class TriviaDbIntermediary
    {
        private TriviaDbAccess triviaDbAccess;

        public string DBError { get; set; }

        public DataTable Leaderboard()
        {
            try
            {
                triviaDbAccess = new TriviaDbAccess();
                string sqlQuery = "select name, score from score;";
                DataSet scoretable = triviaDbAccess.GenericQuery(sqlQuery);
                return scoretable.Tables[0];
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }

        public void AddQuestionWithAnswers(MultipleChoiceQuestion question)
        {
            try
            {
                triviaDbAccess = new TriviaDbAccess();

                int correctAnswerId = AddAnswer(question.CorrectAnswer);
                AddAnswer(question.SecondAnswer);
                AddAnswer(question.ThirdAnswer);
                AddAnswer(question.FourthAnswer);

                int questionId = AddQuestion(question.Question, question.Category, question.Difficulty);

                UpdateQuestionWithAnswer(correctAnswerId, questionId);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }
        }

        private int GetCategoryID(string categoryName)
        {
            string sqlQuery = "SELECT ID FROM Category WHERE Category = @Category";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("Category", categoryName)
            };

            return triviaDbAccess.ExecuteScalarQuery(sqlQuery, parameters);
        }

        private int AddAnswer(string answerText)
        {
            string sqlQuery = "INSERT INTO [Option] (OptionText) OUTPUT INSERTED.ID VALUES (@Answer)";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("Answer", answerText)
            };

            return triviaDbAccess.ExecuteScalarQuery(sqlQuery, parameters);
        }

        private int AddQuestion(string questionText, string category, string difficulty)
        {
            string sqlQuery = "INSERT INTO Question (QuestionText, CategoryID, Difficulty) OUTPUT INSERTED.ID VALUES (@Question, @CategoryID, @Difficulty)";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("Question", questionText),
                new SqlParameter("CategoryID", GetCategoryID(category)),
                new SqlParameter("Difficulty", difficulty)
            };

            return triviaDbAccess.ExecuteScalarQuery(sqlQuery, parameters);
        }

        private void UpdateQuestionWithAnswer(int answerId, int questionId)
        {
            string sqlQuery = "UPDATE Question SET Answer = @Answer WHERE ID = @QuestionID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("Answer", answerId),
                new SqlParameter("QuestionID", questionId)
            };

            triviaDbAccess.ExecuteScalarQuery(sqlQuery, parameters);
        }
    }
}
