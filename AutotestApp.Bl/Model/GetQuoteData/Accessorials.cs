using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Bl.Model.GetQuoteData
{
    public class Accessorials
    {
        public List<Accessorial> originalSite { get; set; }
        public List<Accessorial> originalNonCommercial { get; set; }
        public List<Accessorial> originAccessorials { get; set; }
        public List<Accessorial> destinationAccessorials { get; set; }
        public List<Accessorial> destinationSite { get; set; }
        public List<Accessorial> destinationNonCommercial { get; set; }
        public List<Accessorial> nonSpecificAccessorials { get; set; }
    }
}

