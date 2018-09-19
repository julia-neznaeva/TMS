using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class FreightClassModel
    {
        public int FreightClassId { get; set; } //(int, not null)
        public string Code { get; set; } //(nvarchar(10), null)
        public string Description { get; set; } //(nvarchar(255), null)
        public string PFortyFourClass { get; set; } //(nvarchar(50), not null)
    }
}
