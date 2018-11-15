using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DataAccessClassLibrary;
using DataAccessClassLibrary.Models;


namespace TriviaGame
{
    class TriviaDbIntermediary
    {
        private TriviaDbAccess triviaDbAccess = new TriviaDbAccess();

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

        public IEnumerable<MultipleChoiceQuestion> GetQuestions(string category)
        {
            string sqlQuery = "SELECT ID, QuestionText, Difficulty FROM Question WHERE CategoryID = @CategoryID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("CategoryID", GetCategoryID(category))
            };

            DataSet questionDataSet = triviaDbAccess.GenericQuery(sqlQuery, parameters);

            List<MultipleChoiceQuestion> questions = questionDataSet.Tables[0].AsEnumerable().Select(dataRow => new MultipleChoiceQuestion
            {
                QuestionID = dataRow.Field<int>("ID"),
                Question = dataRow.Field<string>("QuestionText"),
                Difficulty = dataRow.Field<string>("Difficulty"),
                Category = category
            }).ToList();

            questions.ForEach(q =>
            {
                DataSet answerDataSet = GetWrongAnswersByQuestionID(q.QuestionID);
            });

            return questions;
        }

        private DataSet GetWrongAnswersByQuestionID(int questionId)
        {
            string sqlQuery = "SELECT O.OptionText FROM [Option] O" +
                "JOIN Question_Option QO ON O.ID = QO.OptionID" +
                "JOIN Question Q ON QO.QuestionID = Q.ID" +
                "WHERE Q.ID = @QuestionID" +
                "AND O.ID <> Q.Answer";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("QuestionID", questionId)
            };

            return triviaDbAccess.GenericQuery(sqlQuery, parameters);
        }
    }
}
