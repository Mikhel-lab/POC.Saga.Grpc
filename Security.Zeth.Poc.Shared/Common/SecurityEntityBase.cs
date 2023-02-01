using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Zeth.Poc.Shared.Common
{
    public abstract class SecurityEntityBase
    {
        public int Id { get; protected set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; }
    }
}
