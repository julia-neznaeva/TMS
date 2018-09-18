using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotestApp.Dal.Session;
using AutotestApp.Dal.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using AutotestApp.Common;

namespace AutotestApp.Dal.Repositories
{
    public interface ICustomerInviteRepositoriy
    {
        CustomerInviteModel GetCustomerInviteModel(Int32 userPersonalInfoId);
    }

    public class CustomerInviteRepositoriy : ICustomerInviteRepositoriy
    {
        private ISession _session;
        String connectionString => Config.Instance.MyCarrierContext;

        public CustomerInviteRepositoriy(ISession session)
        {
            _session = session;
        }

        public CustomerInviteModel GetCustomerInviteModel(Int32 userPersonalInfoId)
        {
            CustomerInviteModel customerInvite = new CustomerInviteModel();
            String query = $"SELECT * FROM CustomerInvite WHERE CustomerInviteId = {userPersonalInfoId}";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                customerInvite = db.QueryFirstOrDefault<CustomerInviteModel>(query);
            }
            return customerInvite;

        }

        public CustomerInviteModel GetCustomer(int userPersonalInfoId)
        {
            throw new NotImplementedException();
        }
    }
}
