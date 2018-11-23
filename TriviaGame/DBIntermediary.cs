using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using DataAccessClassLibrary;
using DataAccessClassLibrary.Models;

namespace TriviaGame
{
    class DBIntermediary
    {
        private DBAccess dbAccess = new DBAccess();

        public string DBError { get; set; }

        /**
         * Retrieve scores from database
         */
        public DataTable Leaderboard()
        {
            try
            {
                string sqlQuery = "SELECT Name, Score FROM Score";

                DataSet dataSet = dbAccess.GenericQuery(sqlQuery);

                return dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }

        /**
         * Add a player's score to the database
         */
        public void AddScore(string name, int score)
        {
            try
            {
                string sqlQuery = "INSERT INTO Score (Name, Score) VALUES (@Name, @Score)";

                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("Name", name),
                    new SqlParameter("Score", score)
                };

                dbAccess.ExecuteScalarQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }
        }

        /**
         * Main method to add a user-created question to the database
         */
        public void AddQuestionWithAnswers(Question question)
        {
            try
            {
                // Get question ID so we can link it to answers
                int questionId = InsertIntoQuestionTable(question.Text, question.Category, question.Difficulty);

                // For each answer, insert into database
                question.Answers.ForEach(a =>
                {
                    int id = InsertIntoOptionTable(a.Text);
                    InsertIntoQuestionOptionTable(questionId, id);

                    // If the answer is the correct one, update the question table to link it
                    if (a.IsCorrect)
                    {
                        UpdateQuestionTableWithCorrectAnswer(id, questionId);
                    }
                });
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }
        }

        /**
         * Insert QuestionID & OptionID into Question_Option table to link option to question
         */
        private void InsertIntoQuestionOptionTable(int questionId, int optionId)
        {
            try
            {
                string sqlQuery = "INSERT INTO Question_Option (QuestionID, OptionID) VALUES (@QuestionID, @OptionID)";

                List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter("QuestionID", questionId),
                    new SqlParameter("OptionID", optionId)
                };

                dbAccess.ExecuteNonQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }
        }

        /**
         * Get the ID for a given category so it can be inserted in the Question table
         */
        private int GetCategoryID(string categoryName)
        {
            int categoryId = 0;

            try
            {
                string sqlQuery = "SELECT ID FROM Category WHERE Category = @Category";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("Category", categoryName)
                };

                categoryId = dbAccess.ExecuteScalarQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }

            return categoryId;
        }

        /**
         * Add option to Option table
         */
        private int InsertIntoOptionTable(string optionText)
        {
            string sqlQuery = "INSERT INTO [Option] (OptionText) OUTPUT INSERTED.ID VALUES (@OptionText)";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("OptionText", optionText)
            };

            return dbAccess.ExecuteScalarQuery(sqlQuery, parameters);
        }

        /**
         * Add question to Question table
         */
        private int InsertIntoQuestionTable(string questionText, string category, string difficulty)
        {
            int questionId = 0;

            try
            {
                string sqlQuery = "INSERT INTO Question (QuestionText, CategoryID, Difficulty) OUTPUT INSERTED.ID VALUES (@Question, @CategoryID, @Difficulty)";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("Question", questionText),
                    new SqlParameter("CategoryID", GetCategoryID(category)),
                    new SqlParameter("Difficulty", difficulty)
                };

                questionId = dbAccess.ExecuteScalarQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }

            return questionId;
        }

        /**
         * Update the Question table with the correct option ID so we know which option is the correct one
         */
        private void UpdateQuestionTableWithCorrectAnswer(int answerId, int questionId)
        {
            try
            {
                string sqlQuery = "UPDATE Question SET Answer = @Answer WHERE ID = @QuestionID";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("Answer", answerId),
                    new SqlParameter("QuestionID", questionId)
                };

                dbAccess.ExecuteNonQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }
        }

        /**
         * Main method to retrieve all questions for a given category to show the user
         * when they start to play the game
         */
        public IEnumerable<Question> GetQuestions(string category)
        {
            DataSet questionDataSet = new DataSet();

            try
            {
                string sqlQuery = "SELECT Q.ID, Q.QuestionText, O.OptionText, Q.Difficulty, Q.Answer " +
                "FROM [Option] O " +
                "JOIN Question Q ON Q.Answer = O.ID " +
                "WHERE Q.CategoryID = @CategoryID";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("CategoryID", GetCategoryID(category))
                };

                // Get all questions and correct answers in a category
                questionDataSet = dbAccess.GenericQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }

            // Create and populate list with question data set
            List<Question> questions = questionDataSet.Tables[0].AsEnumerable().Select(dataRow => new Question
            {
                ID = dataRow.Field<int>("ID"),
                Text = dataRow.Field<string>("QuestionText"),
                Difficulty = dataRow.Field<string>("Difficulty"),
                Answers = new List<Answer>()
                {
                    new Answer(dataRow.Field<string>("OptionText"), true)
                },
                Category = category
            }).ToList();

            // For each question, get wrong answers and then add to question in random order
            questions.ForEach(q =>
            {
                DataSet answerDataSet = GetWrongAnswersByQuestionID(q.ID);

                List<string> answers = answerDataSet.Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<string>("OptionText")).ToList();

                answers.ForEach(a => q.Answers.Add(new Answer(a)));

                q.Answers = q.Answers.OrderBy(a => Guid.NewGuid()).ToList();
            });

            // Return questions in random order
            return questions.OrderBy(q => Guid.NewGuid());
        }

        /**
         * Retrieves wrong answers for a given question since correct answer is retrieved with the question
         */
        private DataSet GetWrongAnswersByQuestionID(int questionId)
        {
            DataSet dataSet = new DataSet();

            try
            {
                string sqlQuery = "SELECT O.OptionText FROM [Option] O " +
                "JOIN Question_Option QO ON O.ID = QO.OptionID " +
                "JOIN Question Q ON QO.QuestionID = Q.ID " +
                "WHERE Q.ID = @QuestionID " +
                "AND O.ID <> Q.Answer";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("QuestionID", questionId)
                };

                dataSet = dbAccess.GenericQuery(sqlQuery, parameters);
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
            }

            return dataSet;
        }
    }
}
