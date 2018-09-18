using AutotestApp.Common;
using AutotestApp.Dal.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using AutotestApp.Dal.Session;

namespace AutotestApp.Dal.Repositories
{
    public interface IUserPersonalInfoRepositoriy
    {
        UserPersonalInfoModel GetUserPersonalInfo(String email);
    }

    public class UserPersonalInfoRepositoriy: IUserPersonalInfoRepositoriy
    {
        private ISession _session;

        public UserPersonalInfoRepositoriy(ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public UserPersonalInfoModel GetUserPersonalInfo(String email)
        {
            UserPersonalInfoModel user = new UserPersonalInfoModel();

            String query = $"SELECT * FROM UserPersonalInfo WHERE Email ='{email}'";

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                user = db.QueryFirstOrDefault<UserPersonalInfoModel>(query);
            }
            return user;
        }
    }
}
