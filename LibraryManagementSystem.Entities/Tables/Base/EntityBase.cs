using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities.Tables.Base
{
    public class EntityBase
    {
        public Guid ID { get; set; }
        public string Ekleyen { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public string Duzenleyen { get; set; }
        public DateTime? DuzenlenmeTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}
