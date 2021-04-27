using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotellIsaacChristopher.Models
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("FK_Booking")]
        public int? BookingID { get; set; }
        public List<Booking> Booking { get; set; }
        [ForeignKey("FK_Order")]
        public int? OrderID { get; set; }
        public Order Order { get; set; }
    }
}