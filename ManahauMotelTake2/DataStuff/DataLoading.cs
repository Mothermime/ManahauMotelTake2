using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ManahauMotelTake2.DataStuff;
using System.Windows.Forms;


namespace ManahauMotelTake2
{
    static class DataLoading

    {
        // static Room myRoom = new Room();
        //static Guest myGuest = new Guest();
        public static DataGridView dgvRooms { get; set; }
        public static DataGridView dgvReservations { get; set; }
        public static DataGridView dgvBills { get; set; }
        public static DateTime BookingFrom { get; private set; }
        public static DateTime BookingTo { get; private set; }


        public static List<int> allRoomsFree = new List<int>();

        public static DataGridView CurrentGuests()
        {
            // to show a dgv of all the guests currently checked in in order of next to check out and then by name
            using (var context = new ManahauMotelEntities())
            {
                var alldata = from j in context.Joins
                                  // where j.Booking.BookingFrom <= DateTime.Today.Date
                              where j.Booking.CheckIn <= DateTime.Now
                              where j.Booking.CheckOut == null
                              orderby j.Booking.BookingTo ascending, j.Booking.Guest.Name ascending

                              // where j.Booking.CheckIn != null && j.Booking.CheckIn == null
                              select new
                              {
                                  j.Booking.BookingID,
                                  j.Booking.BookingFrom,
                                  j.Booking.BookingTo,
                                  j.Room.RoomID,
                                  j.Room.Room_Name,
                                  j.Booking.Guest.Name,
                                  j.Booking.Guest.No_ofGuests,
                                  j.Booking.Guest.Notes,
                                  j.Booking.CheckIn,
                                  j.Booking.CheckOut,
                                  j.Booking.Guest.GuestID,
                              };
                dgvReservations.DataSource = alldata.ToList();
            }
            return dgvReservations;
        }

        public static void Reservations()
        {
            //to get the list of reservations coming up (pending)
            using (var context = new ManahauMotelEntities())
            {
                // var alldata = from b in context.Bookings
                var alldata = from j in context.Joins
                              where j.Booking.BookingFrom >= DateTime.Today.Date
                              where j.Booking.CheckIn.Value == null
                              orderby j.Booking.BookingFrom ascending

                              select new
                              {
                                  j.Booking.BookingID,
                                  // j.Booking.Guest.GuestID,
                                  j.Booking.BookingFrom,
                                  j.Booking.BookingTo,
                                  j.Room.RoomID,
                                  j.Room.Room_Name,
                                  j.Booking.Guest.Name,
                                  j.Booking.Guest.No_ofGuests,
                                  j.Booking.Guest.Notes,
                                  j.Booking.CheckIn,
                                  j.Booking.CheckOut,
                                  j.Booking.Guest.GuestID,


                              };

                //this did work and now it doesn't - something to do with the Guest IDFK being nullable but I can't change the datatable to disallow nullables & even though it tells me that I can't allow nullables it is set to allowing them AArgh!!!
                dgvReservations.DataSource = alldata.ToList();
            }
        }

        public static DataGridView TodaysReservations()
        {
            //to get the reservations for the current day only i.e. guests expected today
            using (var context = new ManahauMotelEntities())
            {

                var alldata = from j in context.Joins
                              where j.Booking.BookingFrom == DateTime.Today.Date

                              orderby j.Booking.Guest.Name ascending

                              select new
                              {
                                  j.Booking.BookingID,
                                  j.Booking.BookingFrom,
                                  j.Booking.BookingTo,
                                  j.Room.RoomID,
                                  j.Room.Room_Name,
                                  j.Booking.Guest.Name,
                                  j.Booking.Guest.No_ofGuests,
                                  j.Booking.Guest.Notes,
                                  j.Booking.CheckIn,
                                  j.Booking.CheckOut,
                                  j.Booking.Guest.GuestID,
                              };


                dgvReservations.DataSource = alldata.ToList();


            }
            return dgvReservations;
        }

        public static DataGridView Allreservations()
        {
            //to list all the reservations in the history of the motel  in alphabetical guest order
            using (var context = new ManahauMotelEntities())
            {
                var alldata = from j in context.Joins
                              orderby j.Booking.Guest.Name ascending
                              // orderby j.Booking.BookingFrom ascending
                              select new
                              {
                                  j.Booking.BookingID,
                                  j.Booking.BookingFrom,
                                  j.Booking.BookingTo,
                                  j.Room.RoomID,
                                  j.Room.Room_Name,
                                  j.Booking.Guest.Name,
                                  j.Booking.Guest.No_ofGuests,
                                  j.Booking.CheckIn,
                                  j.Booking.CheckOut,
                                  j.Booking.Guest.GuestID,
                                 
                              };
                dgvReservations.DataSource = alldata.ToList();


            }
            return dgvReservations;
        }

        public static DataGridView LoadBookings()
        {
            //to load in the new guest and booking details
            using (var context = new ManahauMotelEntities())
            {

                var alldata =
                    //context.Joins.OrderByDescending(j => j.Booking.BookingFrom).Select(j => j.Booking.BookingFrom);    
                    from j in context.Joins
                    where j.Booking.BookingFrom >= DateTime.Now
                    //where j.Booking.CheckIn >= DateTime.Now
                    orderby j.Booking.BookingFrom ascending

                    select new
                    {
                        j.BookingIDFK,
                        //j.Room,
                        j.Booking.BookingFrom,
                        j.Booking.BookingTo,
                        j.Room.RoomID,
                        j.Room.Room_Name,
                        j.Booking.Guest.Name,
                        // j.Booking.Guest.Address,
                        // j.Booking.Guest.Phone,
                        j.Booking.Guest.No_ofGuests,
                        j.Booking.Guest.Notes,
                        j.Booking.CheckIn,
                        j.Booking.CheckOut,
                        j.Booking.Guest.GuestID

                    };

                dgvReservations.DataSource = alldata.ToList();
            }
            return dgvReservations;
        }

        public static void AllRooms()
        {
            //  shows the data grid view with all the room details listed in it - basically a test to see if the query works
            using (var context = new ManahauMotelEntities())
            {
                var alldata = from r in context.Rooms
                              select new
                              {
                                  r.RoomID,
                                  r.RoomType,
                                  r.Room_Name,
                                  r.Double_Beds,
                                  r.Single_Beds,
                                  r.ExtraBeds
                              };
                dgvRooms.DataSource = alldata.ToList();
            }
        }

        //public static List<Room> RoomsAvailable()
        //{
        //    using (var context = new ManahauMotelEntities())

        //    {
        //        var roomDetails = context.Rooms.ToList();


        //        return roomDetails;

        //    }
        //}


        //todo Show reservations with booking in and out and check in and out  
        //  list by order of date, highlight any who have missed check in
        //todo  get list of rooms, 
        //find free rooms from dates,
        //todo connect list to data gridview  - work out what the query shoud be
        //todo add in the costs, calculating the costs for the length of stay  
        //check in guests
        //todo Generate bill with any extra costs



        //public static DataGridView LoadFreeRooms()
        //{
        //    //  allRoomsFree.AddRange(GetFreeRooms().ToList());
        //    //GetFreeRooms();
        //    var dgvRooms = new DataGridView();
        //    using (var context = new ManahauMotelEntities())
        //    {
        //        var freeRooms =
        //            context.Rooms.Where(r => allRoomsFree.Contains(r.RoomID))
        //                .Select(
        //                    r =>
        //                        new
        //                        {
        //                            Room = r.RoomID,
        //                            roomName = r.Room_Name,
        //                            roomType = r.RoomType,
        //                            Doublebeds = r.Double_Beds,
        //                            Singlebeds = r.Single_Beds,
        //                            Extrabeds = r.ExtraBeds
        //                        });
        //        dgvRooms.DataSource = freeRooms.ToList();

        //        //get the free rooms for the DGV to show


        //    }
        //    return dgvRooms;
        //}

        public static void ChoooseRoom()
        {
            using (var context = new ManahauMotelEntities())
            {
                var alldata = from r in context.Rooms
                              select new
                              {
                                  r.RoomID,
                                  r.RoomType,
                                  r.Room_Name,
                                  r.Double_Beds,
                                  r.Single_Beds,
                              };
                dgvRooms.DataSource = alldata.ToList();
            }
        }

        public static DataGridView LoadBills()
        {
            decimal WiFiCharge = 0;
            decimal TelephoneCharge = 0;
            decimal BarCharge = 0;
            using (var context = new ManahauMotelEntities())
            {
                var loadBill = context.Joins.Where(j => j.Booking.GuestIDFK == j.Booking.Guest.GuestID)
                    .Select(
                        j =>
                            new
                            {
                                j.Booking.Guest.Name,
                                j.Billing.RoomCharge,
                                j.Billing.BarCharge,
                                j.Billing.TelephoneCharge,
                                j.Billing.WiFiCharge
                            });
                    //.SingleOrDefault();
                dgvBills.DataSource = loadBill.ToList();
                //        DataTransition.RoomCharge = loadBill.RoomCharge;
                //        DataTransition.BarCharge = loadBill.BarCharge.Value;
                //        DataTransition.PhoneCharge = loadBill.TelephoneCharge.Value;
                //        DataTransition.WiFiCharge = loadBill.WiFiCharge.Value;

                //        DataTransition.TotalCharges =
                //            DataTransition.RoomCharge + DataTransition.BarCharge + DataTransition.PhoneCharge +
                //            DataTransition.WiFiCharge;


            }
            return dgvBills;
        }

        //        public static void OpenAccount()
        //        {
        //            string Name = DataTransition.Name;
        //            int RoomID = DataTransition.RoomID;
        //            decimal WiFiCharge = 0;
        //            decimal TelephoneCharge = 0;
        //            decimal BarCharge = 0;
        //            using (var context = new ManahauMotelEntities())

        //            {
        //                               var account = from j in context.Joins.Where(j=> j.Booking.BookingID == j.BookingIDFK)
        //// = from b in context.Bookings.Where(b => b.Guest.GuestID == b.GuestIDFK)
        //                    select new
        //                    {
        //                        j.Booking.Guest.Name, 
        //                        j.Room.RoomID,
        //                        j.Billing.RoomCharge, 
        //                       j.Billing.WiFiCharge,
        //                        j.Billing.TelephoneCharge,
        //                        j.Billing.BarCharge,


        //                    };
        //                //context.Joins.Add(account);
        //                context.SaveChanges();

        //              // dgvBills.DataSource = account.ToList();

        //            }


        /// <summary>
        ///     Get the rooms that are free
        /// </summary>
        ///// <returns>List of the free rooms</returns>
        //public static IEnumerable<int> GetFreeRooms()
        //{
        //    List<int> allRoomsFreeId;
        //    using (var context = new ManahauMotelEntities())
        //    {
        //        //get all the bookings after today
        //        var allBookedRooms =
        //            context.Joins.Where(join => join.Booking.BookingFrom >= DateTime.Today)
        //                .Select(join => new {join.RoomIDFK, join.Booking.BookingFrom, join.Booking.BookingTo})
        //                .OrderBy(join => join.RoomIDFK)
        //                .ThenBy(join => join.BookingFrom);
        //            //context.Bookings.Where(b => b.BookingFrom >= DateTime.Today)
        //            //    .Select(b => new { b.RoomIDFK, b.BookingFrom, b.BookingTo })
        //            //    .OrderBy(b => b.RoomIDFK)
        //            //    .ThenBy(b => b.BookingFrom);


        //        //get all the rooms in total 
        //        var allRooms = context.Rooms.Select(r => r.RoomID);

        //        //make a list of all the room numbers (maybe i could leave it as allrooms but whatever)
        //        allRoomsFreeId = new List<int>(allRooms.ToList());

        //        //loop through all the booked rooms 
        //        foreach (var bookedRoom in allBookedRooms)
        //        {
        //            //find if the booking dates are inside the room dates and remove the rooms from the list if they conflict
        //            if (DoTheDatesOverlap(BookingFrom, BookingTo, bookedRoom.BookingFrom, bookedRoom.BookingTo))
        //            {
        //                if (allRoomsFreeId.Contains(Convert.ToInt32(bookedRoom.RoomIDFK)))
        //                {
        //                    //remove rooms from the list of all rooms that are in conflict
        //                    allRoomsFreeId.Remove(Convert.ToInt32(bookedRoom.RoomIDFK));
        //                }
        //            }
        //        }
        //    } 
        //    return allRoomsFreeId;

        //}

        ///// <summary>
        /////     Return a bool if the room dates overlap or not
        ///// </summary>
        //private static bool DoTheDatesOverlap(DateTime start1, DateTime end1, DateTime? start2, DateTime? end2)
        //{
        //    return (end1 >= start2) && (end2 >= start1);
        //}


    }
}

