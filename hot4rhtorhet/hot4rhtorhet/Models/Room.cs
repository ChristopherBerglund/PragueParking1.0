using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hot4rhtorhet.Models
{
    public class Room
    {
        public int ID { get; set; }
        public int RoomNumber { get; set; }
        public decimal RoomPrice { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomDescription { get; set; }




        //public bool IsActive { get; set; }
        //public int BookingStatusID { get; set; }
        //public int RoomTypeID { get; set; }

    }
}
