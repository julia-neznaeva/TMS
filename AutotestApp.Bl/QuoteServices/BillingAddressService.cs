using AutotestApp.Dal.Models;
using AutotestApp.Dal.Repositories;
using AutotestApp.Dal.Session;
using System;

namespace AutotestApp.Bl.QuoteServices
{
    public class BillingAddressService
    {
        public AddressModel GetBillingAddress(String email)
        {
            using (ISession session = SessionFactory.Create())
            {
                UserPersonalInfoModel userPersonalInfoModel = RepositoriyFactory.GetRepo<IUserPersonalInfoRepositoriy>(session).GetUserPersonalInfo(email);
                CustomerInviteModel customerInvite = RepositoriyFactory.GetRepo<ICustomerInviteRepositoriy>(session).GetCustomerInviteModel(userPersonalInfoModel.UserPersonalInfoId);
                AddressModel result= RepositoriyFactory.GetRepo<IAddressRepositoriy>(session).GetAddress("CustomerId", customerInvite.CustomerId);
                return result;
            }
        }
    }
}
