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
        AddressModel GetAddress(String @string, Int32 CustomerId);
    }

    public class AddressRepositoriy: IAddressRepositoriy
    {
        ISession _ssesion;
        public AddressRepositoriy(ISession session)
        {
            _ssesion = session;
        }

        //public AddressModel GetAddress(String @string, Int32 customerId)
        //{
        //    String query = $"SELECT * from ADDRESS WHERE CustomerId = {@string = customerId.ToString()}";

        //    AddressModel address = _ssesion.Connection.QueryFirstOrDefault<AddressModel>(query);

        //    return address;

        //}

        String connectionString => Config.Instance.MyCarrierContext;

        public AddressModel GetAddress(string @string, int CustomerId)
        {
            AddressModel address;
            String query = $"SELECT * from ADDRESS WHERE CustomerId = {@string = CustomerId.ToString()}";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                address = db.QueryFirstOrDefault<AddressModel>(query);

            }
            return address;
        }
    }
}
