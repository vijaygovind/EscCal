using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscCalc.Domain.Entities.Models
{
    class CasePropertiesContext : DbContext
    {
        public CasePropertiesContext(): base("name=ESCCALCEntities1")
        {

        }
        public List<TxnCase> cases { get; set; }
    }
}
