using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class PackageTypeModel
    {
            public int PackageTypeId { get; set; } //(int, not null)
            public string Code { get; set; } //(nvarchar(16), not null)
            public string Description { get; set; } //(nvarchar(16), not null)
            public bool IsHazmatOnly { get; set; } //(bit, not null)
            public bool IsHandlingUnitOnly { get; set; } //(bit, not null)
    }
}
