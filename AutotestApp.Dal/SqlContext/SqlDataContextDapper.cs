using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.SqlContext
{
    class SqlDataContextDapper : SqlDataContextBase
    {
        public override bool ExecuteNonQuery(string query, object parameters = null)
        {
            throw new NotImplementedException(); 
        }

        public override Task<bool> ExecuteNonQueryAsync(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<string> ExecuteQueryWithSimpleResponse(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<string>> ExecuteQueryWithSimpleResponseAsync(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public override Task<TResult> ExecuteSingleOrDefaultAsync<TResult>(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public override TResult ExecuteSingleOrDefaultResult<TResult>(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TResult> ExecuteTableQuery<TResult>(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<TResult>> ExecuteTableQueryAsync<TResult>(string query, object parameters = null)
        {
            throw new NotImplementedException();
        }
    }
}
