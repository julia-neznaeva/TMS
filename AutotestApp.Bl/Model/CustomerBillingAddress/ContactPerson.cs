using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Models.Api.ResponseData.CustomerBillingAddress
{
    public class ContactPerson
    {
        [DeserializeAs(Name = "addressContactId")]
        public Int32  AddressContactId { get; set; }
        [DeserializeAs(Name = "name")]
        public String Name { get; set; }
        [DeserializeAs(Name = "firstName")]
        public String FirstName { get; set; }
        [DeserializeAs(Name = "lastName")]
        public String LastName { get; set; }
        [DeserializeAs(Name = "phone")]
        public String Phone { get; set; }
        [DeserializeAs(Name = "ext")]
        public object Ext { get; set; }
        [DeserializeAs(Name = "email")]
        public String Email { get; set; }
        [DeserializeAs(Name = "position")]
        public object Position { get; set; }
        [DeserializeAs(Name = "isPrimary")]
        public Boolean isPrimary { get; set; }
    }
}
