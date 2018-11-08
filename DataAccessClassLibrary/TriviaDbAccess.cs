using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void openDBConnection()
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
                this.openDBConnection();
                trivAdapter.Fill(triviaDataSet);
                return triviaDataSet;
            }
            finally
            {
                this.CloseDBConnection();
            }
        }

    }
}
