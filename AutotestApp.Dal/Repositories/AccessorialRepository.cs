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
    public interface IAccessorialRepository
    {
        List<AccessorialModel> GetOriginalSiteAccessorials();
        List<AccessorialModel> GetOriginalNonCommercialAccessorials();
        List<AccessorialModel> GetOriginalAccessorials();
        List<AccessorialModel> GetDestinationAccessorials();
        List<AccessorialModel> GetDestinationSiteAccessorials();
        List<AccessorialModel> GetDestinationNonCommercialAccessorials();
        List<AccessorialModel> GetNonSpecificAccessorials();
    }

    public class AccessorialRepository: IAccessorialRepository
    {
        private ISession _session;

        public AccessorialRepository(ISession session)
        {
            _session = session;
        }

        String connectionString => Config.Instance.MyCarrierContext;

        public List<AccessorialModel> GetOriginalSiteAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial 
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId 
                                                    WHERE AccessorialType.Name like ' Site Type'").ToList();
            }
        }

        public List<AccessorialModel> GetOriginalNonCommercialAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId
                                                    WHERE AccessorialType.Name = 'Non-Commercial' AND Code IS NOT NULL").ToList();
            }
        }

        public List<AccessorialModel> GetOriginalAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId
                                                    WHERE AccessorialType.Name = 'Accessorial' AND Code IS NOT NULL AND Code NOT LIKE 'ELS_%'").ToList();
            }
        }

        public List<AccessorialModel> GetDestinationAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId
                                                    WHERE AccessorialType.Name = 'Accessorial' AND DestinationCode IS NOT NULL").ToList();
            }
        }

        public List<AccessorialModel> GetDestinationSiteAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial 
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId
                                                    WHERE AccessorialType.Name like ' Site Type'").ToList();
            }
        }

        public List<AccessorialModel> GetDestinationNonCommercialAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId
                                                    WHERE AccessorialType.Name = 'Non-Commercial' AND DestinationCode IS NOT NULL").ToList();
            }
        }

        public List<AccessorialModel> GetNonSpecificAccessorials()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<AccessorialModel>($@"SELECT Accessorial.* FROM Accessorial
                                                        JOIN AccessorialType ON Accessorial.AccessorialTypeId = AccessorialType.AccessorialTypeId
                                                    WHERE AccessorialType.Name = 'Non-Specific Accessorials'").ToList();
            }
        }
    }
}
