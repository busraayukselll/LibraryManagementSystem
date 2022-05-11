
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Entities.Tables;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    class StudentMap : EntityTypeConfiguration <Student>
    {
        public StudentMap()
        {

            ToTable("Students");
            Property(p => p.No).HasColumnName("studentNo");
            Property(p => p.Debt).HasColumnName("studentDebt");

        }
    }
}
