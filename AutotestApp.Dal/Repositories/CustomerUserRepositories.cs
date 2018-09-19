using AutotestApp.Common;
using AutotestApp.Dal.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotestApp.Dal.Session;

namespace AutotestApp.Dal.Repositories
{
    public interface ICustomerUserRepository
    {
        CustomerUserModel GetCustomerUser(int userId);
    }

    public class CustomerUserRepository : ICustomerUserRepository
    {
        private ISession _session;

        public CustomerUserRepository(ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public CustomerUserModel GetCustomerUser(Int32 userId)
        {
            CustomerUserModel customerUser = new CustomerUserModel();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                customerUser = db.QueryFirstOrDefault< CustomerUserModel >($"SELECT * FROM CustomerUser WHERE UserId = {userId}");

            }
            return customerUser;
        }

    }
}
