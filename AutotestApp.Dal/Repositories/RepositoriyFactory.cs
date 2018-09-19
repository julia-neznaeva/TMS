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

            else if (type == typeof(ICustomerUserRepository))
                repository = new CustomerUserRepository(session);

            else if (type == typeof(ICustomerUserRepository))
                repository = new CustomerUserRepository(session);

            else if (type == typeof(ILocationRepository))
                repository = new LocationRepository(session);

            else if (type == typeof(IAddressContactRepositoriy))
                repository = new AddressContactRepositoriy(session);

            else if (type == typeof(ICustomerRepository))
                repository = new CustomerRepository(session);

            else if (type == typeof(IAccessorialRepository))
                repository = new AccessorialRepository(session);

            else if (type == typeof(IPackageTypeRepository))
                repository = new PackageTypeRepository(session);

            else if (type == typeof(IHolidayRepository))
                repository = new HolidayRepository(session);

            else if (type == typeof(IFreightClassRepository))
                repository = new FreightClassRepository(session);



            return (T)repository;
        }
    }
}
