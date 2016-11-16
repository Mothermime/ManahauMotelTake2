using ManahauMotelTake2.DataStuff;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManahauMotelTake2
{
    class BookingOperations
    {
        public static TextBox txtGuestID { get; set; }
        public static int BookingIDForGuest;

       
        public static void CheckIn()
        {
            using (var context = new ManahauMotelEntities())
            {
                var booking = context.Bookings.SingleOrDefault(b => b.BookingID == BookingIDForGuest);
                booking.CheckIn = DateTime.Now;
                context.Bookings.AddOrUpdate();
                context.SaveChanges();
            }
        }

        public static void CheckOut()
        {
            using (var context = new ManahauMotelEntities())
            {
                var booking = context.Bookings.SingleOrDefault(b => b.BookingID == BookingIDForGuest);
                booking.CheckOut = DateTime.Now;
                context.Bookings.AddOrUpdate();
                context.SaveChanges();
            }
        }

        public static void DeleteBooking()
        {
            try
            {
                using (var context = new ManahauMotelEntities())
            {              ;
              var contact = context.Bookings.SingleOrDefault(b => b.BookingID == BookingIDForGuest);
          
                context.Bookings.Remove(contact);
              
                context.SaveChanges();
                   
            }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);

            }



        }
    }
}
