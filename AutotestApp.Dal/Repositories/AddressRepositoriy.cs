using AutotestApp.Dal.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotestApp.Dal.Models;
using Dapper;
using AutotestApp.Common;
using System.Data;
using System.Data.SqlClient;

namespace AutotestApp.Dal.Repositories
{
    public interface IAddressRepositoriy
    {
        AddressModel GetBilllingAddress(String @string, Int32 customerId);
        AddressModel GetDedicatedAddress(Int32 customerId);
    }

    public class AddressRepositoriy: IAddressRepositoriy
    {
        ISession _ssesion;
        public AddressRepositoriy(ISession session)
        {
            _ssesion = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public AddressModel GetBilllingAddress(string @string, int customerId)
        {
            AddressModel address;
            String query = $"SELECT * from ADDRESS WHERE CustomerId = {@string = customerId.ToString()} and IsBillingAddress = 1";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                address = db.QueryFirstOrDefault<AddressModel>(query);

            }
            return address;
        }

        public AddressModel GetDedicatedAddress(Int32 customerId)
        {
            String query = $"SELECT * from ADDRESS WHERE CustomerId = {customerId.ToString()} and IsThirdPartyBillingEnabled = 1";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.QueryFirstOrDefault<AddressModel>(query);

            }
        }

    }
}
