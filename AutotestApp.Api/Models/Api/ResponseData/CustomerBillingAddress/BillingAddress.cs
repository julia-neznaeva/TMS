using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress
{
    public class BillingAddress
    {
        [DeserializeAs(Name = "addressId")]
        public Int32 AddressId { get; set; }
        [DeserializeAs(Name = "streetLine1")]
        public String StreetLine1 { get; set; }
        [DeserializeAs(Name = "streetLine2")]
        public String StreetLine2 { get; set; }
        [DeserializeAs(Name = "postalCode")]
        public String PostalCode { get; set; }
        [DeserializeAs(Name = "city")]
        public String City { get; set; }
        [DeserializeAs(Name = "state")]
        public String State { get; set; }
        [DeserializeAs(Name = "country")]
        public String Country { get; set; }
        [DeserializeAs(Name = "isCanada")]
        public Boolean IsCanada { get; set; }
        [DeserializeAs(Name = "companyName")]
        public String CompanyName { get; set; }
        [DeserializeAs(Name = "stateCode")]
        public String StateCode { get; set; }
        [DeserializeAs(Name = "pickUpInstruction")]
        public String PickUpInstructions { get; set; }
        [DeserializeAs(Name = "deliveryInstraction")]
        public String DeliveryInstructions { get; set; }
        [DeserializeAs(Name = "lat")]
        public Double Lat { get; set; }
        [DeserializeAs(Name = "long")]
        public Double Long { get; set; }
        [DeserializeAs(Name = "shippingFromTime")]
        public String ShippingFromTime { get; set; }
        [DeserializeAs(Name = "shippingToTime")]
        public String ShippingToTime { get; set; }
        [DeserializeAs(Name = "deliveryFromTime")]
        public String DeliveryFromTime { get; set; }
        [DeserializeAs(Name = "deliveryToTime")]
        public String DeliveryToTime { get; set; }
        [DeserializeAs(Name = "location")]
        public Location Location { get; set; }
        [DeserializeAs(Name = "contactPerson")]
        public ContactPerson ContactPerson { get; set; }
        [DeserializeAs(Name = "addressAccessorials")]
        public List<object> AddressAccessorials { get; set; }
        [DeserializeAs(Name = "commercialType")]
        public String CommercialType { get; set; }
    }

}
