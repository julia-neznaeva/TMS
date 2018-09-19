using AutotestApp.Common;
using AutotestApp.Dal.Models;
using AutotestApp.Dal.Session;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Repositories
{
    public interface ICustomerRepository
    {
        CustomerModel GetCustomer(Int32 customerId);
    }

    public class CustomerRepository: ICustomerRepository
    {
        ISession _ssesion;
        public CustomerRepository(ISession session)
        {
            _ssesion = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public CustomerModel GetCustomer(Int32 customerId)
        {
            String query = $"SELECT * from Customer WHERE CustomerId = {customerId.ToString()}";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.QueryFirstOrDefault<CustomerModel>(query);
            }
        }
    }
}
