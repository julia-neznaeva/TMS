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
    public interface IHolidayRepository
    {
        List<HolidayModel> GetHolidays();
    }

    public class HolidayRepository: IHolidayRepository
    {
        private ISession _session;

        public HolidayRepository(ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public List<HolidayModel> GetHolidays()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<HolidayModel>($"SELECT * FROM  Holiday").ToList();
            }
        }
    }
}
