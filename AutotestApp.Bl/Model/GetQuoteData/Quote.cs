using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class Quote
    {
        public Accessorials accessorials { get; set; }
        public List<GeneralType> packageTypes { get; set; }
        public List<GeneralType> hazardPackingTypes { get; set; }
        public List<GeneralType> freightClasses { get; set; }
        public List<DisabledDate> disabledDates { get; set; }
        public List<DisabledDate> vltlDisabledDates { get; set; }
        public List<CustomerAddress> customerAddresses { get; set; }
        public bool isExistConnectedCarriers { get; set; }
        public bool isRequiredNmfcCode { get; set; }
        public String specialInstructionDefaultText { get; set; }
        public bool isShowVLTLToggle { get; set; }
    }
}
