using System;
using SQLite;

namespace SQLiteSample.Services
{
	public partial class GenerateConnection
    {
        // required for platform 
        public partial ConnectionInfo GetConnection();

        public GenerateConnection()
        {
            ConnectionInfo connectionInfo = this.GetConnection();
            _sqliteconnection = connectionInfo.ConnConnection;
            ConnException = connectionInfo.ConnException;
            Filespec = connectionInfo.Filespec;

            if (ConnException != null)
            {
                throw ConnException;
            }
        }

        private SQLiteConnection _sqliteconnection;
        public SQLiteConnection Connection
        {
            get
            {
                return _sqliteconnection;
            }
        }

        public string Filespec { get; private set; }

        public Exception ConnException { get; private set; }
    }

    public class ConnectionInfo
    {
        public SQLiteConnection ConnConnection;
        public Exception ConnException;
        public string Filespec;
    }
}

