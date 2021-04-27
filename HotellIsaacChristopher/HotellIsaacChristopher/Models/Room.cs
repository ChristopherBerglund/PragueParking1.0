using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotellIsaacChristopher.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int NoOfBeds { get; set; }
        public double PricePerNight { get; set; }
        public bool NeedsCleaning { get; set; }
        [ForeignKey("FK_Booking")]
        public int? BookingID { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
