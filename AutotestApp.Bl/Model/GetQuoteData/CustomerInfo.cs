using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class CustomerInfo
    {
        public Boolean IsExistConnectedCarriers { get; set; }
        public Boolean IsRequiredNmfcCode { get; set; }
        public Boolean IsShownVlTLToggle { get; set; }
        public String SpecialInstructionDefaultText { get; set; }
    }
}
