using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SyngentaGatewayApp.Entity
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public ulong Id { get; set; }
        [Browsable(false)]
        public virtual bool? isDelete { get; set; }
        [Browsable(false)]
        public virtual bool? isEnable { get; set; }
        [JsonProperty("createdAt")]
        [NotNull]
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        [JsonProperty("updatedAt")]
        [NotNull]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}
