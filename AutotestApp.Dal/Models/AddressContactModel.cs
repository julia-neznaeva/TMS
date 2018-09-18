using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class AddressContactModel
    {
            public int AddressContactId { get; set; } //(int, not null)
            public string FirstName { get; set; } //(nvarchar(100), null)
            public string LastName { get; set; } //(nvarchar(100), null)
            public string Phone { get; set; } //(nvarchar(20), null)
            public string Email { get; set; } //(nvarchar(255), null)
            public string Position { get; set; } //(nvarchar(100), null)
            public bool IsPrimary { get; set; } //(bit, not null)
            public string Ext { get; set; } //(nvarchar(6), null)
            public int AddressId { get; set; } //(int, not null)

    }
}
