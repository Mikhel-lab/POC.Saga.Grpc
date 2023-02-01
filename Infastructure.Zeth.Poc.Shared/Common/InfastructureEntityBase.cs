using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Infastructure.Zeth.Poc.Shared.Common
{
    public abstract class InfastructureEntityBase
    {
        public int Id { get; protected set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; }
    }
}
