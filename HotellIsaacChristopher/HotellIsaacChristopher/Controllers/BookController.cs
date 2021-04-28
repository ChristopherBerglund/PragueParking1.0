using HotellIsaacChristopher.Data;
using HotellIsaacChristopher.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotellIsaacChristopher.Controllers
{
    public class BookController : Controller
    {
        private readonly HotellIsaacDbContext _context;

        public BookController(HotellIsaacDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LookForAvailableRooms(DateTime BookFrom, DateTime BookTo, int NoOfMembers)
        {
            
           

            //var incheckningdatum = _context.Bokningar.Select(x => x.Incheckning).ToList();
            //var utcheckningdatum = _context.Bokningar.Select(x => x.Utcheckning).ToList();

            //var ledigaplatser = 


            //ViewBag.DateFrom = BookFrom;
            //ViewBag.DateTo = BookTo;
            //ViewBag.Number = NoOfMembers;

            //foreach (Rum item in _context.Rum)
            //{
            //    ViewBag.Rooms = item.Namn;
            //}
            List<Room> NotAvailable = new List<Room>();
            

            var Antalupptagnaplatserinnomspannet = _context.Bookings.Where(x => x.CheckIn >= BookFrom && x.CheckOut <= BookTo)
                                            .Select(x => x.Room.NoOfBeds).Sum();

            List<Room> AllaRum = new List<Room>();
            var Upptagnarum = _context.Bookings.Where(x => x.CheckIn >= BookFrom && x.CheckOut <= BookTo)
                                            .Select(x => x.Room).ToList();
            foreach (var line in _context.Rooms)
            {
                AllaRum.Add(line);
            }

            foreach (Room item in AllaRum)
            {
                foreach (Room item1 in Upptagnarum)
                {
                    if(item == item1)
                    {
                        AllaRum.Remove(item1);
                    }
                            
                }
            }




            //TempData["tidfrån"] = BookFrom;
            //TempData["tidtill"] = BookTo;
           





            var totalaplatser = _context.Rooms.Select(x => x.NoOfBeds).Sum();
            bool RoomsAreAvailable;

            var checkInned = BookFrom;
            ViewBag.Inchecked = checkInned;
         

            if (totalaplatser - Antalupptagnaplatserinnomspannet >= NoOfMembers)
            {
                ViewBag.IsRoomAvailable = RoomsAreAvailable = true;

                ViewBag.Rumsinfo =
                    "Wooho! We have the perfect room available for your, " + AllaRum[0].RoomName.ToString() +
                    " is avaible " + (BookTo - BookFrom).TotalDays + " night for the total sum of: " +
                    (BookTo - BookFrom).TotalDays * AllaRum[0].PricePerNight + " SEK";

                int bookedRoomID = AllaRum[0].RoomID;
                ViewBag.bookfrom = BookFrom;
                ViewBag.bookto = BookTo;
                ViewBag.RoomId = bookedRoomID;
                ViewBag.ToBeBooked = AllaRum[0];
                return View();
            }
            else
            {
                
                ViewBag.Errormessage = "Tyvärr fanns inga rum som matchade din sökning.";
                return View();
            }

           





        }
        private bool BokningExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingID == id);
        }



        public IActionResult ConfirmBooking(string _FirstName, string _LastName, DateTime _BookFrom, DateTime _BookTo, int _BookedRoomID, Room _ToBeBooked) //string _FirstName, string _LastName, string Email, List<Room> AllaRum
        {




            var guester = new Guest
            {
                FirstName = _FirstName,
                LastName = _LastName,
                BookingID =
            };
            _context.AddRange(guester);
            _context.SaveChanges();

            var orderer = new Order
            {
                Price = (_BookTo - _BookFrom).TotalDays * _ToBeBooked.PricePerNight,
                GuestID = guester.GuestID,
                Guest = guester
            };
            _context.AddRange(orderer);
            _context.SaveChanges();

            var bookinger = new Booking
            {
                CheckIn = _BookFrom,
                CheckOut = _BookTo,
                GuestID = guester.GuestID,
                Guest = guester,
                RoomID = _BookedRoomID,
                Room = _ToBeBooked

            };
            _context.AddRange(bookinger);
            _context.SaveChanges();
            return View();
        }
    }
}
