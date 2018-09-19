using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class GeneralType
    {
        public string code { get; set; }
        public string description { get; set; }

        public Boolean Equals(GeneralType other)
        {
            return code.Equals(other.code) &&
                    description.Equals(other.description);
        }
    }
}
