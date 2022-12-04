using SQLite;

namespace SQLiteSample.Services
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
