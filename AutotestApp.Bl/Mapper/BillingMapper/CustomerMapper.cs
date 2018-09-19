using AutotestApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutotestApp.Bl.Model.GetQuoteData;

namespace AutotestApp.Bl.Mapper.BillingMapper
{
    public static class CustomerMapper
    {
        public static CustomerInfo MapToCustomerInfo(CustomerModel customer)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.SpecialInstructionDefaultText = customer.SpecialInstructionDefaultText;
            customerInfo.IsRequiredNmfcCode = customer.IsRequiredNmfcCode;
            return customerInfo;
        }
    }
}
