using System.Data.SQLite;

namespace DB.Connector
{
    public static class DBConnector
    {
        private static string _databaseName = "URLInfos.sqlite";
        private static string _path;
        private static string _connectionString;
        private static SQLiteConnection _connection;

        public static void CreateDB(string path)
        {
            _path = path + "\\" + _databaseName;
            SQLiteConnection.CreateFile(_path);
            _connectionString = $"Data Source={_path};";

            using(_connection = new SQLiteConnection(_connectionString))
            {
                _connection.Open();
                string commandText = "CREATE TABLE UserInfo (" +
                    "UserId INT PRIMARY KEY," +
                    "UserName VARCHAR(100) NOT NULL UNIQUE," +
                    "Email TEXT NOT NULL UNIQUE," +
                    "Password TEXT NOT NULL" +
                    ");" +
                    "" +
                    "CREATE TABLE URLInfo (" +
                    "UrlId INT PRIMARY KEY," +
                    "UrlHash TEXT NOT NULL UNIQUE," +
                    "ORIGINUrl TEXT NOT NULL UNIQUE," +
                    "Created DATE NOT NULL," +
                    "CreatedBy INT NOT NULL, " +
                    "FOREIGN KEY(CreatedBy) REFERENCES UserInfo(UserId)" +
                    ")";

                using(var command = _connection.CreateCommand())
                {
                    command.CommandText = commandText;
                    command.ExecuteNonQuery();
                }

                _connection.Close();
            }
        }

        public static SQLiteConnection CreateConnection()
        {
            _connection = new SQLiteConnection(_connectionString);
            _connection.Open();
            return _connection;
        }
    }
}
