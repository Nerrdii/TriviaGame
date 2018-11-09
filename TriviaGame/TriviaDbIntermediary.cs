using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace TriviaGame
{
    class TriviaDbIntermediary
    {
        public string DBError { get; set; }

        public DataTable Leaderboard()
        {
            try
            {
                DataAccessClassLibrary.TriviaDbAccess accessToDB = new DataAccessClassLibrary.TriviaDbAccess();
                string sqlQuery = "select name, score from score;";
                DataSet scoretable = accessToDB.GenericQuery(sqlQuery);
                return scoretable.Tables[0];
            }
            catch (Exception ex)
            {
                DBError = ex.Message;
                return null;
            }
        }
    }
}
