using System;
using MySql.Data.MySqlClient;

public class DbUtil
{
	public DbUtil()
	{
        public static MySqlConnection GetSqlConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "gestion_bank";
            string username = "root";
            string password = "";

            return DB.GetSqlConnection(host, port, database, username, password);
        }
    }
}
