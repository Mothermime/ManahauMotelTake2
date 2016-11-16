using ManahauMotelTake2.DataStuff;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManahauMotelTake2
{
    static class GuestDetails
    {
        public static int GuestID { get; set; }
        public static int Name { get; set; }
        public static int Phone { get; set; }
        public static int Address { get; set; }
        public static int Notes { get; set; }
        public static int BookingIDForGuest;
        public static DataGridView dgvGuests { get; set; }
        public static TextBox txtName { get; set; }
        public static TextBox txtAddress { get; set; }
        public static TextBox txtPhone { get; set; }
        public static TextBox txtNumGuests { get; set; }
        public static TextBox txtNotes { get; set; }

        //public static TextBox txtName = new TextBox();
        //public static TextBox txtAddress = new TextBox();
        //public static TextBox txtPhone = new TextBox();
        //public static TextBox txtNumGuests = new TextBox();



        public static TextBox txtBookedFrom = new TextBox();
        public static TextBox txtBookedTo = new TextBox();
        // public static TextBox txtNotes = new TextBox();
        public static DateTimePicker dtpBookFrom = new DateTimePicker();
        public static DateTimePicker dtpBookedTo = new DateTimePicker();
        public static TextBox txtRoomId = new TextBox();

        //public static TextBox txtBookedFrom = txtBookedFrom;
        //public static TextBox txtBookedTo = txtBookedTo;
        //public static TextBox txtNotes = txtNotes;
        //public static string Name;
        //public static string Address;
        //public static string Phone;
        //public static string NumGuests;
        //public static string Notes;


        public static void Allguests()
        {
            // Loads the datagrid view with all the guests in the database
            using (var context = new ManahauMotelEntities())
            {
                var alldata = from g in context.Guests
                   orderby g.Name ascending
                              select new
                    {
                        g.GuestID,
                        g.Name,
                        g.Address,
                        g.Phone,
                        g.Notes
                    };
                dgvGuests.DataSource = alldata.ToList();
                context.SaveChanges();
            }
        }

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

        public static void AddGuest()
        {
            {

                if (txtName.Text != String.Empty || txtAddress.Text != String.Empty || txtPhone.Text != String.Empty ||
                    txtNumGuests.Text != String.Empty)
                {
                    using (var context = new ManahauMotelEntities())
                    {
                        // var guest = new Guest();
                        Guest guest = new Guest();
                        guest.Name = txtName.Text;
                        guest.Address = txtAddress.Text;
                        guest.Phone = txtPhone.Text;
                        guest.No_ofGuests = Convert.ToInt32(txtNumGuests.Text);
                        guest.Notes = txtNotes.Text;

                        // var booking = new Booking();
                        Booking booking = new Booking();
                        booking.BookingFrom = dtpBookFrom.Value.Date;
                        booking.BookingTo = dtpBookedTo.Value.Date;
                        booking.GuestIDFK = guest.GuestID;



                        context.Guests.Add(guest);
                        context.Bookings.Add(booking);

                        Room room = new Room();
                        room.RoomID = Convert.ToInt32(txtRoomId.Text);
                        Join join = new Join();
                        join.RoomIDFK = room.RoomID;
                        join.BookingIDFK = booking.BookingID;
                        context.Joins.Add(join);
                        context.SaveChanges();
                    }
                    GuestDetails.Allguests();

                }

            }
        }

        public static void UpdateGuest()
        {
            try
            {
  using (var context = new ManahauMotelEntities())
                        {
              var guest = context.Guests.SingleOrDefault(g => g.GuestID == GuestID);
                //var guest = context.Joins.Where(j => j.)
              //var guest = new Guest();
                            guest.Name = txtName.Text;
                            guest.Address = txtAddress.Text;
                            guest.Phone = txtPhone.Text;
                           // guest.No_ofGuests = Convert.ToInt32(txtNumGuests.Text);
                            guest.Notes = txtNotes.Text;

                            context.Guests.AddOrUpdate(guest);
                            context.SaveChanges();
                            Allguests();
                            MessageBox.Show(txtName.Text + " updated," );

                        }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
                      
        }

        public static DataGridView ConnectDatagrids(string GuestIDfromdgv)
        {
            using (var context = new ManahauMotelEntities())
            {
                int GuestIDagain = Convert.ToInt32(GuestIDfromdgv);
                var alldata = from g in context.Guests
                              where g.GuestID == GuestIDagain
                //var alldata = from g in context.Guests.SingleOrDefault()
                //              where g.GuestID == GuestID

                              select new
                             {
                                 g.GuestID,
                                 g.Name,
                                 g.Address,
                                 g.Phone,
                                 g.Notes
                             };
              
                dgvGuests.DataSource = alldata.ToList();
                context.SaveChanges();
                return dgvGuests;
            }
        }
    }
}
    



        


    


       
    
    

