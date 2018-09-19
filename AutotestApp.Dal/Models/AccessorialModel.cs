using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class AccessorialModel
    {
            public int AccessorialId { get; set; } //(int, not null)
            public string Name { get; set; } //(nvarchar(50), null)
            public string Code { get; set; } //(nvarchar(20), null)
            public string DestinationCode { get; set; } //(nvarchar(20), null)
            public int AccessorialTypeId { get; set; } //(int, null)
            public bool IsOnlyForCanada { get; set; } //(bit, not null)
            public bool IsOnlyForUSA { get; set; } //(bit, null)
            public decimal MinValue { get; set; } //(decimal(18,4), null)
            public decimal MaxValue { get; set; } //(decimal(18,4), null)
            public bool IsInternal { get; set; } //(bit, not null)

    }
}
