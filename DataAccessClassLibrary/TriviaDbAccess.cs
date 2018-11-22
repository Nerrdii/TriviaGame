using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

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
                OpenDBConnection();
                trivAdapter.Fill(triviaDataSet);
                return triviaDataSet;
            }
            finally
            {
                CloseDBConnection();
            }
        }

        public DataSet GenericQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            DataSet triviaDataSet = new DataSet();

            try
            {
                SqlDataAdapter trivAdapter = new SqlDataAdapter(sqlQuery, GetDBConnection());

                parameters.ForEach(param => trivAdapter.SelectCommand.Parameters.AddWithValue(param.ParameterName, param.Value));

                OpenDBConnection();
                trivAdapter.Fill(triviaDataSet);
                return triviaDataSet;
            }
            finally
            {
                CloseDBConnection();
            }
        }

        public int ExecuteScalarQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            parameters.ForEach(param => command.Parameters.AddWithValue(param.ParameterName, param.Value));

            OpenDBConnection();

            int returnValue = (int)command.ExecuteScalar();

            CloseDBConnection();

            return returnValue;
        }

        public void ExecuteNonQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand(sqlQuery, GetDBConnection());
            parameters.ForEach(param => command.Parameters.AddWithValue(param.ParameterName, param.Value));

            OpenDBConnection();

            command.ExecuteNonQuery();

            CloseDBConnection();
        }
    }
}
