using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress
{
    public class Location
    {
        [DeserializeAs(Name = "addressId")]
        public Int32 AddressId { get; set; }
        [DeserializeAs(Name = "addressId")]
        public String Name { get; set; }
        [DeserializeAs(Name = "isDefault")]
        public Boolean IsDefault { get; set; }
    }
}
