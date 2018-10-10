using System.IO;
using SQLite;
using SQLiteSample.Helpers;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteSample.Android.Implementations.AndroidSQLite))]
namespace SQLiteSample.Android.Implementations
{
    public class AndroidSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            // Documents folder  
            var path = Path.Combine(documentsPath, DatabaseHelper.DbFileName);
            var conn = new SQLiteConnection(path);

            // Return the database connection  
            return conn;
        }
    }
}
