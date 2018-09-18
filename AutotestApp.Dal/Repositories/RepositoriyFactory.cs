using AutotestApp.Dal.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Repositories
{
    public static class RepositoriyFactory
    {
        public static T GetRepo<T>(ISession session)
        {
            Type type = typeof(T);
            Object repository = null;

            if (type == typeof(IAddressRepositoriy))
                repository = new AddressRepositoriy(session);

            else if (type == typeof(IUserPersonalInfoRepositoriy))
                repository = new UserPersonalInfoRepositoriy(session);

            else if (type == typeof(ICustomerInviteRepositoriy))
                repository = new CustomerInviteRepositoriy(session);

            return (T)repository;
        }
    }
}
