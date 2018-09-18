using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class LocationModel
    {
            public int AddressId { get; set; } //(int, not null)
            public string Name { get; set; } //(nvarchar(128), null)
            public int CustomerId { get; set; } //(int, null)
            public bool IsAddress { get; set; } //(bit, not null)
            public bool IsRemoved { get; set; } //(bit, not null)
            public long P44CapacityProviderAccountGroupId { get; set; } //(bigint, null)
            public string P44CapacityProviderAccountGroupCode { get; set; } //(nvarchar(512), null)
            public string P44BillingAddressId { get; set; } //(nvarchar(50), null)
            public string P44CapacityProviderAccountGroupName { get; set; } //(nvarchar(522), null)

    }
}
