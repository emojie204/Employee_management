using MySql.Data.MySqlClient;

namespace asm_csharp.Data
{
	public class DBMySql
	{
		private static string HostName = "localhost";
		private static string UserName = "root";
		private static string Password = "";
		private static string Database = "asm_csharp";

		private static int port = 3306;
		public static MySqlConnection GetMySqlConnection()
		{
			string connStr = String.Format("Server={0};Database={1};User={2};Password={3};Port={4}", HostName, Database, UserName, Password, port);
			return new MySqlConnection(connStr);
		}
	}
}
