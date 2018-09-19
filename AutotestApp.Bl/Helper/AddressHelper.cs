using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Helper
{
    public static class AddressHelper
    {
        public static Dictionary<String, String> _countryCode =  new Dictionary<String, String>();

        static AddressHelper()
        {
            _countryCode.Add("US", "USA");
        }

        public static String GetCountry(String code)
        {
            return _countryCode[code];
        }

    }
}
