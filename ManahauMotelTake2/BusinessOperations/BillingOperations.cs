using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManahauMotelTake2.DataStuff;

namespace ManahauMotelTake2
{
    class BillingOperations
    {
        public static DataGridView dgvBills;
              
      

       
        public decimal Tariff { get; set; }
        public decimal ExtraTariff { get; set; }

        public static TextBox txtRoomCharge { get; set; }
        public static TextBox txtWifi { get; set; }
        public static TextBox txtBarCharge{ get; set; }
        public static TextBox txtPhoneCharge { get; set; }
        public static TextBox txtGuestName { get; set; }
        public static TextBox txtRoomId { get; set; }
        public static void DaysBooked()
        {

            DataTransition.NumDaysBooked = (DataTransition.BookedTo.Date - DataTransition.BookedFrom.Date).TotalDays;

           
        }
        //Method not used - trial method
        public static decimal ChargeForRoom(decimal? Tariff)
        {

            DataTransition.RoomPrice = (decimal) Tariff;
            DataTransition.NumDaysBooked = (DataTransition.BookedTo.Date - DataTransition.BookedFrom.Date).TotalDays;

            DataTransition.RoomCharge = Convert.ToDecimal(DataTransition.NumDaysBooked)* DataTransition.RoomPrice;
            return DataTransition.RoomCharge;
        }
       

        public static decimal ChargeForExtras( int guests, decimal? Tariff, decimal? ExtraTariff)

        {
            //Charge for room is the same for one or two people, any extras are a set extra cost
            DataTransition.ExtraCharge = (decimal) ExtraTariff;
            DataTransition.RoomPrice = (decimal) Tariff;
            guests -= 2;

            if (guests <= 0)
            {
                guests = 0;
            }

            while (guests > 0)
            {
                DataTransition.RoomPrice += DataTransition.ExtraCharge;
                guests -= 1;
            }
            DataTransition.NumDaysBooked = (DataTransition.BookedTo.Date - DataTransition.BookedFrom.Date).TotalDays;

            DataTransition.RoomCharge = Convert.ToDecimal(DataTransition.NumDaysBooked)* DataTransition.RoomPrice;
            return DataTransition.RoomCharge;
        }

       public static  void CalculateBill()
        {//todo connect text boxes to datagrid cell click
            DataTransition.BarCharge = Convert.ToDecimal(txtBarCharge.Text);

                DataTransition.PhoneCharge = Convert.ToDecimal(txtPhoneCharge.Text);
                DataTransition.WiFiCharge = Convert.ToDecimal(txtPhoneCharge.Text);
            //update function
         if (txtGuestName.Text != string.Empty)
            {
                using (var context = new ManahauMotelEntities())
                {   var bill = context.Joins.FirstOrDefault(j => j.BillingIDFK == j.Billing.BillingID);
                    if (bill != null)


                    {
                        bill.Booking.Guest.Name = DataTransition.Name;
                        bill.Room.RoomID = DataTransition.RoomID;
                        bill.Billing.RoomCharge = DataTransition.RoomCharge;
                        bill.Billing.BarCharge = DataTransition.BarCharge;
                        bill.Billing.WiFiCharge = DataTransition.WiFiCharge;
                        bill.Billing.TelephoneCharge = DataTransition.PhoneCharge;
                       
                        context.SaveChanges();
                        //DataLoading.BillForGuest();

                        GuestBill();

                    }
                } 
        }

      }
        public static void GuestBill()
        {
            DataTransition.TotalCharges = DataTransition.RoomCharge + DataTransition.BarCharge +
                                         DataTransition.WiFiCharge
                                         + DataTransition.PhoneCharge;
        }
        }
    }

