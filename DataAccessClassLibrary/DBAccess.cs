using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessClassLibrary
{
    public class DBAccess
    {
        private SqlConnection dbConnection;
        private string connectionString = ConfigurationManager.ConnectionStrings["TriviaGame.Properties.Settings.Setting"].ConnectionString;

        public SqlConnection GetConnection()
        {
            if (dbConnection == null)
            {
                dbConnection = new SqlConnection(connectionString);
                
            }
            return dbConnection;
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }

        public void OpenConnection()
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
        }

        public DataSet GenericQuery(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, GetConnection());

                OpenConnection();

                dataAdapter.Fill(dataSet);

                return dataSet;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataSet GenericQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, GetConnection());

                parameters.ForEach(param => dataAdapter.SelectCommand.Parameters.AddWithValue(param.ParameterName, param.Value));

                OpenConnection();

                dataAdapter.Fill(dataSet);

                return dataSet;
            }
            finally
            {
                CloseConnection();
            }
        }

        /**
         * Execute generic query that returns a scalar value
         */
        public int ExecuteScalarQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            parameters.ForEach(param => command.Parameters.AddWithValue(param.ParameterName, param.Value));

            OpenConnection();

            int scalarValue = (int)command.ExecuteScalar();

            CloseConnection();

            return scalarValue;
        }

        /**
         * Execute generic query that does not return a value
         */
        public void ExecuteNonQuery(string sqlQuery, List<SqlParameter> parameters)
        {
            SqlCommand command = new SqlCommand(sqlQuery, GetConnection());

            parameters.ForEach(param => command.Parameters.AddWithValue(param.ParameterName, param.Value));

            OpenConnection();

            command.ExecuteNonQuery();

            CloseConnection();
        }
    }
}
