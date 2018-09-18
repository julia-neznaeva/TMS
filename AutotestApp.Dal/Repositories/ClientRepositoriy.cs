
using AutotestApp.Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AutotestApp.Dal
{
    public class ClientRepository
    {
        // String connectionString => "data source=10.10.200.62;initial catalog=MyCarrier;user id=sa;password=Qwerty1!;multipleactiveresultsets=True;";
        //ConfigurationManager.AppSettings["MyCarrierContext"];
        String connectionString => Config.Instance.MyCarrierContext;

        public List<Client> GetClient()
        {
            List<Client> users = new List<Client>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                users = db.Query<Client>("SELECT * FROM Client").ToList();

            }
            return users;
        }
    }
}
