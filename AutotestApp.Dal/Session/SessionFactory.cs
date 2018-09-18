using AutotestApp.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Session
{
    public static class SessionFactory
    {
        public static ISession Create()
        {
            String connectionString = Config.Instance.MyCarrierContext;
            IDbConnection connection = new SqlConnection(connectionString);
            return new DapperSession(connection);
        }
    }
}
