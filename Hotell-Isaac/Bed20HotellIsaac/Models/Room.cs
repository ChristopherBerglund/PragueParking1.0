using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bed20HotellIsaac.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomImage { get; set; }
        public decimal RoomPrice { get; set; }
        public int BookingStatusID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomDescription { get; set; }
        //public List<SelectListItem> ListOfBookingStatus { get; set; }
        //public List<SelectListItem> ListOfRoomTypes { get; set; }
    }
}
