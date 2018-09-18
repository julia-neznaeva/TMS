using AutotestApp.Dal.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal
{
    internal abstract class SqlDataContextBase : IDisposable
    {
        private ISession _session;
        private Boolean _isShouldBeDisppose;

        protected ISession Session => _session;

        public SqlDataContextBase(ISession uniOfWork = null)
        {
            if (uniOfWork == null)
            {
                _session = SessionFactory.Create();
                _isShouldBeDisppose = true;
            }
            else
                _session = uniOfWork;
        }

        public void Dispose()
        {
            if (_isShouldBeDisppose)
            {
                try
                {
                    Session.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    ((IDisposable)_session).Dispose();
                }
            }
        }

        /// <summary>
        /// This method returns no result, use it for non-resulted query.
        /// </summary>
        /// <param name="query">Query string.</param>
        //[Obsolete("Use ExecuteNonQueryAsync instead of this method")]
        public abstract Boolean ExecuteNonQuery(String query, Object parameters = null);

        public abstract Task<Boolean> ExecuteNonQueryAsync(String query, Object parameters = null);

        /// <summary>
        /// This method returns table result of query execution.
        /// </summary>
        /// <param name="query">Query string.</param>
        //[Obsolete("Use ExecuteTableQueryAsync instead of this method")]
        public abstract IEnumerable<TResult> ExecuteTableQuery<TResult>(String query, Object parameters = null);

        /// <summary>
        /// This method is async and returns table result of query execution.
        /// Use result.Result for getting result;
        /// </summary>
        /// <example>IEnumerable<TResult> x = result.Result</example>
        /// <param name="query">Query string.</param>
        public abstract Task<IEnumerable<TResult>> ExecuteTableQueryAsync<TResult>(String query, Object parameters = null);

        /// <summary>
        /// This method returns a single result of query execution.
        /// </summary>
        /// <param name="query">Query string.</param>
        //[Obsolete("Use ExecuteSingleOrDefaultAsync instead of this method")]
        public abstract TResult ExecuteSingleOrDefaultResult<TResult>(String query, Object parameters = null);

        public abstract Task<TResult> ExecuteSingleOrDefaultAsync<TResult>(String query, Object parameters = null);

        //[Obsolete("Use ExecuteQeuryWthSimpleResponseAsync instead of this method")]
        public abstract IEnumerable<String> ExecuteQueryWithSimpleResponse(String query, Object parameters = null);

        public abstract Task<IEnumerable<String>> ExecuteQueryWithSimpleResponseAsync(String query, Object parameters = null);


    }
}

