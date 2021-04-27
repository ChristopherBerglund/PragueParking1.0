using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotellIsaacChristopher.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        [ForeignKey("FK_Guest")]
        public int GuestID { get; set; }
        public Guest Guest { get; set; }
        [ForeignKey("FK_Room")]
        public int RoomID { get; set; }
        public Room Room { get; set; }

    }
}