using AutotestApp.Bl.Model.GetQuoteData;
using AutotestApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Mapper.BillingMapper
{
    public static class HolidayMapper
    {
        public static List<DisabledDate> MapToDisabledDates(List<HolidayModel> holidays)
        {
            List<DisabledDate> result = new List<DisabledDate>();
            result.Add(new DisabledDate() { from = null, to = DateTime.Today.AddDays(-1) });
            for (Int32 i = 0; i < holidays.Count; i++)
            {
                result.Add(new DisabledDate() { from = holidays[i ].Date, to = holidays[i].Date });
            }
            return result;
        }
    }
}
