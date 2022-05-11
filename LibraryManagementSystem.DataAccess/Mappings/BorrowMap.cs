using LibraryManagement.Entities.Tables;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Mappings
{
    class BorrowMap : EntityTypeConfiguration<Borrow>
    {
        public BorrowMap() {
          //  Property(p => p.BookID).HasMaxLength(50);
            ToTable("Borrows");
            Property(p => p.BookID).HasColumnName("borrowBookID");
            Property(p => p.UserID).HasColumnName("borrowUserID");
            Property(p => p.BorrowDate).HasColumnName("borrowedBookID");
            Property(p => p.BorrowDate).HasColumnName("borrowDate");
            Property(p => p.IsDelivery).HasColumnName("borrowIsDelivery");


        }
    }

}
