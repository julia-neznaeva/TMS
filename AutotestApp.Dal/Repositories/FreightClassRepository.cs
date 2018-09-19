using AutotestApp.Common;
using AutotestApp.Dal.Models;
using AutotestApp.Dal.Session;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AutotestApp.Dal.Repositories
{
    public interface IFreightClassRepository
    {
        List<FreightClassModel> FreightClasses();
    }
        public class FreightClassRepository: IFreightClassRepository
    {
        private ISession _session;

        public FreightClassRepository(ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public List<FreightClassModel> FreightClasses()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<FreightClassModel>($"SELECT * FROM  FreightClass").ToList();
            }
        }

    }
}
