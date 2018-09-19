using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class Accessorial
    {
        public int accessorialId { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string destinationCode { get; set; }
        public bool isOnlyForCanada { get; set; }
        public bool isOnlyForUSA { get; set; }

        public Boolean Equals(Accessorial other)
        {
            return accessorialId.Equals(other.accessorialId) &&
                   name.Equals(other.name) &&
                   code.Equals(other.code) &&
                   destinationCode.Equals(other.destinationCode) &&
                   isOnlyForCanada.Equals(other.isOnlyForCanada) &&
                   isOnlyForCanada.Equals(other.isOnlyForUSA);

        }


    }
}
