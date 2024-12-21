using System.Data.SQLite;

namespace DB
{
    public static class DBConnector
    {
        private static string _databaseName = "URLInfos.db";
        private static string _path;
        private static string _connectionString;
        private static SQLiteConnection _connection;

        public static void CreateDB(string path)
        {
            _path = path + "\\" + _databaseName;
            SQLiteConnection.CreateFile(path);
            _connectionString = $"Data Source={_path};Version=3;";
        }

        public static SQLiteConnection CreateConnection()
        {
            _connection = new SQLiteConnection(_connectionString);
            _connection.Open();
            return _connection;
        }
    }
}
