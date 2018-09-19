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
    public interface IPackageTypeRepository
    {
        List<PackageTypeModel> GetPackageTypes();
    }

    public class PackageTypeRepository: IPackageTypeRepository
    {
        private ISession _session;

        public PackageTypeRepository(ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public List<PackageTypeModel> GetPackageTypes()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<PackageTypeModel>($"SELECT * FROM  PackageType").ToList();
            }
        }

    }
}
