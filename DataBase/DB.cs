using System;
using MySql.Data.MySqlClient;
public class DB
{
	public DB()
	{
        public static MySqlConnection GetSqlConnection(string host, int port, string database,
                                                       string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                                + ";port=" + port.ToString() + ";User Id=" + username +
                                ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
