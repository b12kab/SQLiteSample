using System;
using SQLite;

namespace SQLiteSample.Helpers
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
