using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using AutotestApp.Bl.Helper;
using AutotestApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Mapper.BillingMapper
{
    public static class BillingAddressMapper
    {
        public static Address GetBillingAddress(LocationModel location, AddressContactModel contact, AddressModel address)
        {
            Address billingAddress = new Address();
            billingAddress.AddressAccessorials = new List<Object>();
            billingAddress.AddressId = address.AddressId;
            billingAddress.City = address.City;
            billingAddress.CommercialType = null;
            billingAddress.CompanyName = address.CompanyName;
            billingAddress.ContactPerson = new ContactPerson();
            billingAddress.ContactPerson.AddressContactId = contact.AddressContactId;
            billingAddress.ContactPerson.Email = contact.Email;
            billingAddress.ContactPerson.Ext = contact.Ext;
            billingAddress.ContactPerson.FirstName = contact.FirstName;
            billingAddress.ContactPerson.isPrimary = contact.IsPrimary;
            billingAddress.ContactPerson.LastName = contact.LastName;
            billingAddress.ContactPerson.Name = contact.FirstName;//&&
            billingAddress.ContactPerson.Phone = contact.Phone;
            billingAddress.ContactPerson.Position = contact.Position;
            billingAddress.Country = AddressHelper.GetCountry( address.CountryCode);
            billingAddress.DeliveryFromTime = address.DeliveryFromTime;
            billingAddress.DeliveryInstructions = address.DeliveryInstructions;
            billingAddress.DeliveryToTime = address.DeliveryToTime;
            billingAddress.IsCanada = address.IsCanada;
            billingAddress.Lat = address.Lat;
            if (location != null)
            {
                billingAddress.Location = new Location();

                billingAddress.Location.AddressId = location.AddressId;
                billingAddress.Location.IsDefault = false;//&&
                billingAddress.Location.Name = location.Name;
            }
            billingAddress.Long = address.Long;
            billingAddress.PickUpInstructions = address.PickUpInstructions;
            billingAddress.PostalCode = address.PostalCode;
            billingAddress.ShippingFromTime = address.ShippingFromTime;
            billingAddress.ShippingToTime = address.ShippingToTime;
            billingAddress.State = address.State;
            billingAddress.StateCode = address.StateCode;
            billingAddress.StreetLine1 = address.StreetLine1;
            billingAddress.StreetLine2 = address.StreetLine2;
            return billingAddress; 
        }

    }
}
