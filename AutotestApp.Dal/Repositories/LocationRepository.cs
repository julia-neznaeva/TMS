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
    public interface ILocationRepository
    {
        LocationModel GetLocation(int addressId);
    }

    public class LocationRepository: ILocationRepository
    {
        private ISession _session;

        public LocationRepository (ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public LocationModel GetLocation(Int32 addressId)
        {
            LocationModel location = new LocationModel();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                location = db.QueryFirstOrDefault<LocationModel>($"SELECT * FROM Location WHERE AddressId = {addressId}");

            }
            return location;
        }
    }
}
