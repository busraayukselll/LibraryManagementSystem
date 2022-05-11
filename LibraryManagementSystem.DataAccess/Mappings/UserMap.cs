using LibraryManagement.Entities.Tables;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            Property(p => p.Name).HasMaxLength(50);

            ToTable("Users");

            Property(p => p.Name).HasColumnName("userName");
            Property(p => p.Surname).HasColumnName("userSurname");
            Property(p => p.Email).HasColumnName("userEmail");
            Property(p => p.Password).HasColumnName("userPassword");
            Property(p => p.Phone).HasColumnName("userPhone");
           // Property(p => p.).HasColumnName("userName");



        }
    }
}
