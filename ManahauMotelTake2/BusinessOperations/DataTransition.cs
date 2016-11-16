using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManahauMotelTake2.DataStuff;

namespace ManahauMotelTake2
{
  static class DataTransition
    {
        public static DateTime BookedTo
        {
            get
; set;
        }
        public static DateTime BookedFrom
        { get; set; }
        
        public static decimal TariffCouple;
        public static decimal TariffExtraPerson;
        public static decimal BarCharge { get; set; }
        public static decimal RoomCharge { get; set; }
        public static decimal DailyCharge { get; set; }
        public static decimal WiFiCharge { get; set; }
        public static decimal PhoneCharge  { get; set; }
        public static double NumDaysBooked;
        public static int RoomID;
        public static int BookingID;
        public static int GuestID;
        public static int BillingID;
        public static Room room = new Room();
        public static Guest guest = new Guest();
        public static Booking Booking = new Booking();
        public static Billing Billing = new Billing();
        public static decimal RoomPrice;
        public static decimal ExtraCharge = 0;
        public static string Name;
       
        public static decimal TotalCharges = 0;

    }
}
