using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class QuoteResponse
    {
        [DeserializeAs(Name = "quote")]
        public Quote Quote { get; set; }
    }
}
