using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Entity
{
    public class MasterData : BaseEntity
    {
        public string Machine {  get; set; }
        public string Line {  get; set; }
        public string Bactch { get; set; }
        public string LOT { get; set; }
        public string GTIN { get; set; }
        public uint ProductCounter { get; set; } 
    }
}
