using System;

namespace AutotestApp.Common.Models.Api.RequestData.ProductApi
{
    public class ProductGetRequestData
    {
        public string ID { get; set; }

        public int Page { get; set; } = 1;

        public int Limit { get; set; }

        public string Name { get; set; }

        public string SKU { get; set; }

        public DateTime? ModifiedSince { get; set; }

        public bool IncludeDeprecated { get; set; }

        public bool IncludeBOM { get; set; }

        public bool IncludeSuppliers { get; set; }

        public bool IncludeMovements { get; set; }

        public bool IncludeAttachments { get; set; }

        public bool IncludeReorderLevels { get; set; }
    }
}
