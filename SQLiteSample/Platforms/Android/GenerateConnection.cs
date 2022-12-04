using SQLiteSample.Helpers;
using SQLite;
using System;
using System.IO;

namespace SQLiteSample.Services;

//https://learn.microsoft.com/en-us/dotnet/maui/platform-integration/invoke-platform-code?view=net-maui-7.0

public partial class GenerateConnection
{
    public partial ConnectionInfo GetConnection()
    {
        string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);

        // Documents folder  
        var path = Path.Combine(documentsPath, DatabaseHelper.DbFileName);

        var connectionInfo = new ConnectionInfo()
        {
            Filespec = path
        };

        for (int i = 0; i < 3; i++)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(path,
                    SQLiteOpenFlags.SharedCache |
                    SQLiteOpenFlags.ReadWrite |
                    SQLiteOpenFlags.Create |
                    SQLiteOpenFlags.FullMutex);

                connectionInfo.ConnConnection = conn;
            }
            catch (System.Exception ex)
            {
                connectionInfo.ConnException = ex;
                connectionInfo.ConnConnection = null;

                System.Diagnostics.Debug.WriteLine("GetConnection() - " +
                    " Try: " + i +
                    ". Failed to get connection. Filespec: '" +
                    path + "' Exception: " + ex.StackTrace);
            }

            if (connectionInfo.ConnConnection != null)
            {
                connectionInfo.ConnException = null;
                break;
            }
        }

        // Return the database connection  
        return connectionInfo;
    }
}
