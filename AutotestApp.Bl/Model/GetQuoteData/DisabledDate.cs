using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class DisabledDate
    {
        public DateTime? from { get; set; }
        public DateTime? to { get; set; }

        public Boolean Equals(DisabledDate other)
        {
            return from==null&&other.from ==null||from.Value.Equals(other.from)&&
                   to.Equals(other.to);
        }
    }
}
