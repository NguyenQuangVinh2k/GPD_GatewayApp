using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.DeserializedClass
{
    public class TestAPI
    {
        public string Status { get; set; }
        public Data Data { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Data
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime AccessExpiredTime { get; set; }
        public DateTime RefreshExpiredTime { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
    }

}
