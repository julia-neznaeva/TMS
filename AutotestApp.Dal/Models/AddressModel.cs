using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class AddressModel
    {
            public int AddressId { get; set; } //(int, not null)
            public string StreetLine1 { get; set; } //(nvarchar(128), null)
            public string StreetLine2 { get; set; } //(nvarchar(128), null)
            public string PostalCode { get; set; } //(nvarchar(16), null)
            public string City { get; set; } //(nvarchar(64), null)
            public string State { get; set; } //(nvarchar(128), null)
            public bool IsCanada { get; set; } //(bit, not null)
            public string GEOCode { get; set; } //(nvarchar(128), null)
            public int CustomerId { get; set; } //(int, not null)
            public string StateCode { get; set; } //(nvarchar(10), null)
            public string ShippingFromTime { get; set; } //(nvarchar(10), null)
            public string ShippingToTime { get; set; } //(nvarchar(10), null)
            public string DeliveryFromTime { get; set; } //(nvarchar(10), null)
            public string DeliveryToTime { get; set; } //(nvarchar(10), null)
            public string CompanyName { get; set; } //(nvarchar(128), null)
            public string CountryCode { get; set; } //(nvarchar(10), null)
            public bool IsBillingAddress { get; set; } //(bit, not null)
            public string BolNotes { get; set; } //(nvarchar(384), null)
            public bool IsSetDefaultAccessorials { get; set; } //(bit, not null)
            public bool IsBillingAddressOnly { get; set; } //(bit, null)
            public decimal Long { get; set; } //(decimal(18,8), null)
            public decimal Lat { get; set; } //(decimal(18,8), null)
            public string DeliveryInstructions { get; set; } //(nvarchar(384), null)
            public string PickUpInstructions { get; set; } //(nvarchar(384), null)
            public bool IsDedicatedThirdParty { get; set; } //(bit, not null)
    }
}
