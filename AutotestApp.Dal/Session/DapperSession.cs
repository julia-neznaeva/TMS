using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Session
{
    public class DapperSession : ISession
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;
        public IDbConnection Connection => _connection;

        public DapperSession(IDbConnection connection)
        {
            _connection = connection;
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public void SaveChanges()
        {
            if (_transaction == null)
                throw new ArgumentException("Transaction is null");

            _transaction.Commit();
            _transaction = null;
        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }

            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }
        }

        public SqlCommand CreateCommand()
        {
            return ((SqlConnection)_connection).CreateCommand();
        }
    }
}
