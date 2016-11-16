using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManahauMotelTake2.DataStuff;


namespace ManahauMotelTake2
{ //booking can take place when there is a room available and the gust is linked to it
   static class ChooseRoom
    {
    static Room myRoom = new Room();
        public static DataGridView dgvRooms { get; set; }
        // DataLoading myDataLoading = new DataLoading(); -- doesn't work because this is a static class.
        private static int? doublebeds;
        private static int spaces;
        private static int spaces1;
        private static int spaces2;
        private static int spaces3;
        public static List<Room> Rooms; //= DataLoading.RoomsAvailable();//use these numbers for billing
        static int?  singlebeds;
        private static int RoomCapacity;
        private static  int? extrabeds;
        private static int Guestnumber = 7;
        public static DateTimePicker dtpBookFrom = new DateTimePicker();
        public static TextBox txtBookedTo = new TextBox();
        public static TextBox txtBookedFrom = new TextBox();
        //num available beds and used for each
        // public static void
        //public static DataGridView AvailableRooms()
        //{
        //    DateTime wantedfrom = dtpBookFrom.Value.Date; // DateTime.Parse(txtBookedFrom.Text);
        //    DateTime wantedto = DateTime.Parse(txtBookedTo.Text);

        //    using (var context = new ManahauMotelEntities())
        //    {

        //        var room = from j in context.Joins
        //                       // where    !( wantedto.Date>=j.Booking.BookingFrom  && wantedto.Date <= j.Booking.BookingTo  ||j.Booking.BookingTo >= wantedfrom.Date && j.Booking.BookingTo <= wantedto.Date)
        //                   where j.Booking.BookingFrom >= DateTime.Today
        //                   where
        //                   wantedfrom.Date >= j.Booking.BookingFrom && wantedfrom.Date <= j.Booking.BookingTo ||
        //                   wantedto >= j.Booking.BookingFrom && wantedto <= j.Booking.BookingTo
        //                   select j.RoomIDFK;
        //        var freerooms = from r in context.Rooms
        //                        where !room.Contains(r.RoomID)

        //                        //Bookingfrom.Date <= wantedto.Date&& BookedTo.Date >= wantedfrom.Date
        //                        select new
        //                        {
        //                            r.RoomID,
        //                            r.Room_Name,
        //                            r.RoomType,
        //                            r.Double_Beds,
        //                            r.Single_Beds,
        //                            r.ExtraBeds,
        //                            r.Overflow
        //                        };
        //        dgvRooms.DataSource = freerooms.ToList();



        //    }
        //    return dgvRooms;
        //}
        public static void FillDoubleBeds(Room room)
        {
            doublebeds = room.Double_Beds;

            while (Guestnumber > 0 && doublebeds > 0)
            {
                 if (Guestnumber <= 2)
            {
                    doublebeds = 1;
            }

            Guestnumber -= 2;
                doublebeds -= 1;
            }
            //fill db reduce guestnumber inc bed in use by one
           
            //if (Guestnumber <= 4)
            //{
            //    doublebedsinuse = 2;
            //}
        }

        public static void FillSingleBeds(Room room)
        {
            singlebeds = room.Single_Beds;

            while (Guestnumber > 0 && singlebeds > 0) //repeat as above =reduce gn by 1 not 2
            {
                if (Guestnumber > 2 && singlebeds >= 1)
                {
                    singlebeds = 1;
                }
                Guestnumber -= 1;
                singlebeds -= 1;

            }
        }

        public static void FillExtraBeds(Room room)
        {
            extrabeds = room.ExtraBeds;
            while (Guestnumber > 0 && extrabeds > 0)
            {
                if (Guestnumber <= 2)
                {
                    extrabeds = 1;

                }
                extrabeds -= 1;
                // extra beds  do same as above to two
            }
        }

        // public static void AvailableRoom()
        //public static int AvailableRoom(int? DoubleBeds, int? SingleBeds, int? ExtraBeds)

        //{
        //    spaces += 1;
        //    spaces1 = (int)doublebeds;
        //    spaces2 = (int)singlebeds;
        //    spaces3 = (int)ExtraBeds;

        //    if (DoubleBeds == 1)
        //    {
        //        spaces1 = 2;
        //    }
        //    if(SingleBeds == 1)
        //    {
        //        spaces2 = 1;
        //    }
        //    if (ExtraBeds == 1)

        //    {
        //        spaces3 = 1;
        //    }
        //    RoomCapacity = (int)spaces1 + (int) spaces2 + (int) spaces3;
        //    return RoomCapacity;
        //    //List<Room> AllRooms = DataLoading.RoomsAvailable();
        //    //{
        //    //    foreach (var room in AllRooms)
        //    //    {
        //    //        FillDoubleBeds(room);
        //    //        FillSingleBeds(room);
        //    //        FillExtraBeds(room);

        //    //    }
        //    //    if (doublebeds == 0 && singlebeds == 0 && extrabeds == 2)
        //    //    {
        //    //        MessageBox.Show("You will need an extra room.");
        //    //    

        //    }
        //   // return; //dgvRooms;
        public static DataGridView AvailableRooms()
        {
            DateTime wantedfrom = dtpBookFrom.Value.Date; // DateTime.Parse(txtBookedFrom.Text);
            DateTime wantedto = DateTime.Parse(txtBookedTo.Text);

            using (var context = new ManahauMotelEntities())
            {

                var room = from j in context.Joins
                               // where    !( wantedto.Date>=j.Booking.BookingFrom  && wantedto.Date <= j.Booking.BookingTo  ||j.Booking.BookingTo >= wantedfrom.Date && j.Booking.BookingTo <= wantedto.Date)
                           where j.Booking.BookingFrom >= DateTime.Today
                           where
                           wantedfrom.Date >= j.Booking.BookingFrom && wantedfrom.Date <= j.Booking.BookingTo ||
                           wantedto >= j.Booking.BookingFrom && wantedto <= j.Booking.BookingTo
                           select j.RoomIDFK;
                var freerooms = from r in context.Rooms
                                where !room.Contains(r.RoomID)

                                //Bookingfrom.Date <= wantedto.Date&& BookedTo.Date >= wantedfrom.Date
                                select new
                                {
                                    r.RoomID,
                                    r.Room_Name,
                                    r.RoomType,
                                    r.Double_Beds,
                                    r.Single_Beds,
                                    r.ExtraBeds,
                                    r.Overflow

                                };
                dgvRooms.DataSource = freerooms.ToList();



            }
            return dgvRooms;
        }

    }
}

