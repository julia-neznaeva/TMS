using System;
using System.Data;
using System.Data.SqlClient;

namespace AutotestApp.Dal.Session
{
    public interface ISession : IDisposable
    {
        SqlCommand CreateCommand();
        void SaveChanges();
        IDbConnection Connection { get; }
    }
}
