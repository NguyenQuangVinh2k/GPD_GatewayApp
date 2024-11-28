using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyngentaGatewayApp.Entity
{
    public class GatewayEntity: BaseEntity
    {
        public string MachineIP { get; set; }
        public int MachinePort { get; set; }
        public string PrinterIP { get; set; }
        public int PrinterPort { get; set; }
        public int GatewayID {  get; set; }
    }
}
