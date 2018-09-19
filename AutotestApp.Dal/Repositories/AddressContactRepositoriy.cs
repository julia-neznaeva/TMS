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
    public interface IAddressContactRepositoriy
    {
        AddressContactModel GetContactPerson(Int32 userPersonalInfoId);
    }


    public class AddressContactRepositoriy : IAddressContactRepositoriy
    {
        private ISession _session;
        String connectionString => Config.Instance.MyCarrierContext;

        public AddressContactRepositoriy(ISession session)
        {
            _session = session;
        }

        public AddressContactModel GetContactPerson(Int32 userPersonalInfoId)
        {
            AddressContactModel contact = new AddressContactModel();
            String query = $"SELECT * FROM AddressContact WHERE AddressId = {userPersonalInfoId}";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                contact = db.QueryFirstOrDefault<AddressContactModel>(query);
            }
            return contact;

        }
    }
}
