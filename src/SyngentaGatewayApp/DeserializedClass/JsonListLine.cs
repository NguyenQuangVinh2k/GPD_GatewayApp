using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.DeserializedClass
{
    public class JsonListLine
    {
        public BusinessErrorListLine businessError { get; set; }
        public List<ReListLine> res { get; set; }
    }
    // JsonListLine myDeserializedClass = JsonConvert.DeserializeObject<JsonListLine>(myJsonResponse);
    public class BusinessErrorListLine
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    public class LineDetailsCollectionListLine
    {
        public int id { get; set; }
        public int level { get; set; }
        public string ipAdress { get; set; }
        public int isActive { get; set; }
        public int lineId { get; set; }
    }

    public class ReListLine
    {
        public int id { get; set; }
        public string name { get; set; }
        public int manfId { get; set; }
        public int plantId { get; set; }
        public int createdBy { get; set; }
        public int? updatedby { get; set; }
        public List<LineDetailsCollectionListLine> lineDetailsCollection { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime? updatedDate { get; set; }
        public int isActive { get; set; }
        public string lineIdentifier { get; set; }
        public string plantName { get; set; }
        public object assignBatchName { get; set; }
        public object ipAddress { get; set; }
        public object level1 { get; set; }
        public object level2 { get; set; }
        public object level3 { get; set; }
        public object level4 { get; set; }
        public object level5 { get; set; }
        public object level6 { get; set; }
    }
}
