using AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
   public class CustomerAddress
    {
        public string description { get; set; }
        public bool isFromAddressBook { get; set; }
        public bool isFromLocation { get; set; }
        public object placeId { get; set; }
        public Address address { get; set; }
    }
}
