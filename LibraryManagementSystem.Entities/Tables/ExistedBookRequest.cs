namespace LibraryManagement.Entities.Tables
{
    public class ExistedBookRequest: Request 
    {
        public virtual Book BookID { get; set; }
        public virtual Borrow DeliveryDate { get; set; }
    }
}
