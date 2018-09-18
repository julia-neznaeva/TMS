using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Dal
{
    public class Client
    {
        public String ClientId { get; set; }
        public String Secret { get; set; }
        public String Name { get; set; }
        public Int32 AplicationType { get; set; }
        public Boolean IsActive { get; set; }
        public Int32 RefreshTokenLifetime { get; set; }
        public String AllowedOrigin { get; set; }
    }
}
