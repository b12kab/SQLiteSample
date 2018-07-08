using System;
using System.IO;
using Xamarin.Forms;
using SQLiteSample.Helpers;
using SQLite;

[assembly: Dependency(typeof(SQLiteSample.iOS.Implementations.IOSSQLite))]
namespace SQLiteSample.iOS.Implementations
{
    public class IOSSQLite : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder  
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder  
            var path = Path.Combine(libraryPath, DatabaseHelper.DbFileName);
            // Create the connection  
            //var plat = new SQLite.Platform.XamarinIOS.SQLitePlatformIOS();
            //var conn = new SQLiteConnection(plat, path);
            var conn = new SQLiteConnection(path);

            // Return the database connection  
            return conn;
        }
    }
}
