using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress
{
    public class BilingAddressTemp
    {
        [DeserializeAs(Name = "billingAddress")]
        public Address BillingAddress { get; set; }
    }
}
