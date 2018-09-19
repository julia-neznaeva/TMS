using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class HolidayModel
    {
        public DateTime Date { get; set; } //(date, not null)
        public string Description { get; set; } //(nvarchar(512), null)
    }
}
