using Newtonsoft.Json;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestApp.Api.Models.Api.ResponseData.Token
{
    public class TokenModel
    {
        [DeserializeAs(Name = "token")]
        public String Token { get; set; }
        [DeserializeAs(Name = "refreshToken")]
        public String RefreshToken { get; set; }
        [DeserializeAs(Name = "userName")]
        public String UserName { get; set; }
    }
}
