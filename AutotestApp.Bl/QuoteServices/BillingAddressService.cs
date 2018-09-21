using AutoMapper;
using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using AutotestApp.Bl.Enums;
using AutotestApp.Bl.Mapper;
using AutotestApp.Bl.Mapper.BillingMapper;
using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Dal.Models;
using AutotestApp.Dal.Repositories;
using AutotestApp.Dal.Session;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutotestApp.Bl.QuoteServices
{
    public class QuoteService
    {
        public Address GetBillingAddress(String email)
        {
            using (ISession session = SessionFactory.Create())
            {
                UserPersonalInfoModel userPersonalInfoModel = RepositoriyFactory.GetRepo<IUserPersonalInfoRepositoriy>(session).GetUserPersonalInfo(email);
                CustomerUserModel customerUser = RepositoriyFactory.GetRepo<ICustomerUserRepository>(session).GetCustomerUser(userPersonalInfoModel.UserPersonalInfoId);
                CustomerModel customer = RepositoriyFactory.GetRepo<ICustomerRepository>(session).GetCustomer(customerUser.CustomerId);
                AddressModel billingAddress= RepositoriyFactory.GetRepo<IAddressRepositoriy>(session).GetBilllingAddress("CustomerId", customerUser.CustomerId);
                AddressModel dedicatedAddress = RepositoriyFactory.GetRepo<IAddressRepositoriy>(session).GetDedicatedAddress(customerUser.CustomerId);

                AddressModel address = (customer.IsThirdPartyBillingEnabled == true) ? dedicatedAddress : billingAddress;

                LocationModel location = RepositoriyFactory.GetRepo<ILocationRepository>(session).GetLocation(address.AddressId);
                AddressContactModel contact = RepositoriyFactory.GetRepo<IAddressContactRepositoriy>(session).GetContactPerson(address.AddressId);
                return BillingAddressMapper.GetBillingAddress(location, contact, address); 
            }
        }

        public List<Accessorial> GetOriginalSiteAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetOriginalSiteAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);
            }
        }

        public List<Accessorial> GetOriginalNonCommercialAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetOriginalNonCommercialAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);
            }
        }

        public List<Accessorial> GetOriginalAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetOriginalAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);

            }
        }

        public List<Accessorial> GetDestinationAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetDestinationAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);

            }
        }

        public List<Accessorial> GetDestinationSiteAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetDestinationSiteAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);
            }
        }

        public List<Accessorial> GetDestinationNonCommercialAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetDestinationNonCommercialAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);
            }
        }

        public List<Accessorial> GetNonCommercialAccessorials()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<AccessorialModel> accessorialModels = RepositoriyFactory.GetRepo<IAccessorialRepository>(session).GetNonSpecificAccessorials();
                return AccessorialMapper.MapToAccessorials(accessorialModels);
            }
        }

        public List<GeneralType> GetPackageType()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<PackageTypeModel> packageTypeModel = RepositoriyFactory.GetRepo<IPackageTypeRepository>(session).GetPackageTypes().Where(x => x.IsHandlingUnitOnly == true).ToList();
                return GeneralTypeMapper.MapPackageToGeneralTypes(packageTypeModel);
            }
        }

        public List<GeneralType> GetHazardPackingTypes()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<PackageTypeModel> packageTypeModel = RepositoriyFactory.GetRepo<IPackageTypeRepository>(session).GetPackageTypes().Where(x => x.IsHazmatOnly == true).ToList();
                return GeneralTypeMapper.MapPackageToGeneralTypes(packageTypeModel);
            }
        }

        public List<DisabledDate> GetDisabledDates()
        {
            using (ISession session = SessionFactory.Create())
            {
                List<HolidayModel> holidays = RepositoriyFactory.GetRepo<IHolidayRepository>(session).GetHolidays();
                return HolidayMapper.MapToDisabledDates(holidays);
            }
        }

        public List<DisabledDate> GetVltlDisabledDates()
        {
            throw new NotImplementedException();
        }

        public List<GeneralType> GetFreightClass()
        {
                using (ISession session = SessionFactory.Create())
                {
                    List<FreightClassModel> freightClasses = RepositoriyFactory.GetRepo<IFreightClassRepository>(session).FreightClasses();
                    return GeneralTypeMapper.MapFreightClassesToGeneralTypes(freightClasses);
                }
            }

        public CustomerInfo GetCustomerInfo(String email)
        {
            using (ISession session = SessionFactory.Create())
            {
                UserPersonalInfoModel userPersonalInfoModel = RepositoriyFactory.GetRepo<IUserPersonalInfoRepositoriy>(session).GetUserPersonalInfo(email);
                CustomerUserModel customerUser = RepositoriyFactory.GetRepo<ICustomerUserRepository>(session).GetCustomerUser(userPersonalInfoModel.UserPersonalInfoId);
                CustomerModel customer = RepositoriyFactory.GetRepo<ICustomerRepository>(session).GetCustomer(customerUser.CustomerId);
                return CustomerMapper.MapToCustomerInfo(customer);
            }
        }
    }

}
