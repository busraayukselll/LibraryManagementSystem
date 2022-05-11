using LibraryManagementSystem.Entities.Tables;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
            
        {

            ToTable("Books");
            Property(p => p.BarcodeNo).HasColumnName("bookBarcodeno");
            Property(p => p.Author).HasColumnName("bookAuthor");
            Property(p => p.Name).HasColumnName("bookName");
            Property(p => p.Location).HasColumnName("bookLocation");

        }
    }
}
