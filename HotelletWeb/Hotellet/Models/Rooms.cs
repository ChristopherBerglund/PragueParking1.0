using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotellet.Models
{
    public class Rooms
    {
        public int ID { get; set; }
        public int RoomNumber { get; set; }
        public byte[] Image { get; set; }
        public decimal RoomPrice { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomDescription { get; set; }
        public bool IsActive { get; set; }

        //public ICollection<RoomTypes> roomtypes { get; set; }
        //public ICollection<BookingStatus> bookinstatus { get; set; }

    }
}
