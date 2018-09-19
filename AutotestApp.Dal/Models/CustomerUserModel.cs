using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal.Models
{
    public class CustomerUserModel
    {
        public int CustomerId { get; set; } //(int, not null)
        public int UserId { get; set; } //(int, not null)
    }
}
