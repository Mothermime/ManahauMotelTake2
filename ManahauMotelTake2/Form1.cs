using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManahauMotelTake2.DataStuff;

namespace ManahauMotelTake2
{
    public partial class Form1 : Form
    {
        Room myRoom = new Room();
        public List<int> allRoomsFree;

        public int GuestID { get; set; }
        public int BookingID { get; set; }
        public decimal TotalCharge { get; set; }

        public Form1()
        {
            //Entity builds the classes according to the database tables - they don't have to be done manually
            //what do I need to do??

            //when programme starts first page visible should
            //show guest reservations with check in and out in order of date, ginving details of room booked
            //
            //be able to book in a person - reservation page to take details of guest - name, rank and serial number, when they want to stay and how many guests.
            //room page, showing availability of room and charges  return to guest reservation page
            InitializeComponent();
            LoadDataGrids();

            // GuestDetails.txtName = txtName;

        }

        public void LoadDataGrids()
        {
            DataLoading.dgvRooms = dgvRooms;
            DataLoading.dgvReservations = dgvReservations;
            GuestDetails.dgvGuests = dgvGuests;
            dgvGuests.Visible = true;
            DataLoading.AllRooms();
            DataLoading.TodaysReservations();
            // DataLoading.Reservations();
            // DataLoading.ChoooseRoom();
            GuestDetails.Allguests();
            dtpBookFrom.MinDate = dtpBookFrom.Value.Date;
            // DataLoading.allRoomsFree();
          // SetVarialbes();
            //txtNumGuests = GuestDetails.txtNumGuests;
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            if (txtNumGuests.Text != string.Empty)
            {
                tabControl1.SelectedIndex = 1;
                // DataLoading.AllRooms();
                PickDates();
                AvailableRooms();
            }
            else
            {
                MessageBox.Show("How many guests? ");
            }

            //DataLoading.LoadFreeRooms( );

            // tabRooms.Visible = true;
            // ChooseRoom.AvailableRoom();
            // DataLoading.RoomsAvailable();

        }

        private void PickDates()
        {
            txtBookedFrom.Text = dtpBookFrom.Value.Date.ToString();
            txtBookedTo.Text = dtpBookedTo.Value.Date.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Updates guests (but not fron the guestdetails class - can't get that to work yet
            MessageBox.Show(txtName.Text + " updated,");
            UpdateGuest();
            GuestDetails.Allguests();



        }

        private void ClearGuesttxtboxes()
        {

            txtName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtNumGuests.Text = String.Empty;
            txtNotes.Text = String.Empty;
            txtBookedFrom.Text = String.Empty;
            txtBookedTo.Text = String.Empty;
            txtRoomId.Text = String.Empty;
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            //txtNumGuests = GuestDetails.txtNumGuests;
            AddGuest();
           // SetBill();

            //AddBooking();
            // GuestDetails.AddGuest();
            // DataLoading.LoadBookings();
            DataLoading.Reservations();
            ClearGuesttxtboxes();
            tabControl1.SelectedIndex = 0;
        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
           // DataLoading.OpenAccount();
            if (dgvReservations.CurrentCell.Selected = true)
                MessageBox.Show(txtName.Text + " has checked in.");
            {
                BookingOperations.CheckIn();
                DataLoading.CurrentGuests();

                tabControl1.SelectedIndex = 0;

                ClearGuesttxtboxes();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            int BookingId = 0;
            int GuestID = 0;
           // DataLoading.LoadBills();
           
            //if (dgvReservations.CurrentCell.Selected = true)


            //{
            //    MessageBox.Show("Please add any extra charges.");
            //    // DataLoading.BillForGuest();
               
            //   BillingOperations.CalculateBill();
            //   // DataLoading.Allreservations();
            //    // BillingOperations.ChargeForRoom(Tariff);
            //   } 
 

        }

        public void AddGuest()
        {//actually adding a booking and connecting it to a room
            try
            {

                if (txtName.Text != String.Empty || txtAddress.Text != String.Empty || txtPhone.Text != String.Empty ||
                    txtNumGuests.Text != String.Empty)
                {
                    using (var context = new ManahauMotelEntities())
                    {
                        
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

 Billing billing = new Billing();
                        billing.RoomCharge = Convert.ToDecimal(txtCostForRoom.Text);

                        context.Guests.Add(guest);
                        context.Bookings.Add(booking);
                        context.Billings.Add(billing);
                       
                   
                        Room room = new Room();
                        room.RoomID = Convert.ToInt32(txtRoomId.Text);
                        Join join = new Join();
                        join.RoomIDFK = room.RoomID;
                        join.BookingIDFK = booking.BookingID;
                        join.BillingIDFK = billing.BillingID;
                       // join.BillingIDFK = billing.BillingID;
                        context.Joins.Add(join);
                        context.SaveChanges();
                    }
                    GuestDetails.Allguests();
                   // DataLoading.BillForGuest(GuestID);
                   //DataLoading.OpenAccount();
                }
                else MessageBox.Show("Please enter all guest details thentry again.");
        }

            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }

}

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

        }

        private void dtpBookFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpBookedTo.MinDate = dtpBookFrom.Value.AddDays(1);

            DataTransition.BookedFrom = dtpBookFrom.Value;
        }

        private void dtpBookedTo_ValueChanged(object sender, EventArgs e)
        {
            DataTransition.BookedTo = dtpBookedTo.Value;
        }

        private void btnAllReservations_Click(object sender, EventArgs e)
        {
            DataLoading.Allreservations();
        }

        private void btnCurrentGuests_Click(object sender, EventArgs e)
        {
            DataLoading.CurrentGuests();
        }

        private void btnReservationsPending_Click(object sender, EventArgs e)
        {
            DataLoading.Reservations();
        }

        private void btnTodaysReservations_Click(object sender, EventArgs e)
        {
            DataLoading.TodaysReservations();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            DialogResult dialogueResult = MessageBox.Show("Are you sure you want to delete this booking?", "",
                MessageBoxButtons.OKCancel);
            if (dialogueResult == DialogResult.OK)
            {
                BookingOperations.DeleteBooking();
                DataLoading.Allreservations();
                tabControl1.SelectedIndex = 0;
                ClearGuesttxtboxes();
            }

        }

        private void btnAllGuests_Click(object sender, EventArgs e)
        {
            GuestDetails.Allguests();
        }

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            BookingOperations.CheckOut();
            ClearGuesttxtboxes();

            MessageBox.Show(txtName.Text + " has checked out.");
        }
        private void dgvReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int BookingID = 0;
             int GuestID = 0;
            tabControl1.SelectedIndex = 2;
            try
            {
                // RoomID = (int) dgvRooms.Rows[e.RowIndex].Cells[0].Value;
                if (e.RowIndex >= 0) //if (e.RowIndex >= 0)
                {
                    {
                        BookingOperations.BookingIDForGuest = (int)dgvReservations.Rows[e.RowIndex].Cells[0].Value;
                        //GuestDetails.BookingIDForGuest = (int)dgvReservations.Rows[e.RowIndex].Cells[0].Value;
                        //GuestID = (int)dgvReservations.Rows[e.RowIndex].Cells[5].Value;
                        txtBookingID.Text = dgvReservations.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtGuestID.Text = dgvReservations.Rows[e.RowIndex].Cells[10].Value.ToString();
                        txtName.Text = dgvReservations.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtGuestName.Text = dgvReservations.Rows[e.RowIndex].Cells[5].Value.ToString();
                        //txtAddress.Text = dgvGuests.Rows[e.RowIndex].Cells[2].Value.ToString();
                        //txtPhone.Text = dgvGuests.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtBookedFrom.Text = dgvReservations.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtBookedTo.Text = dgvReservations.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtNumGuests.Text = dgvReservations.Rows[e.RowIndex].Cells[7].Value.ToString();

                       DataTransition.Booking.BookingID = Convert.ToInt32(txtBookingID.Text);




                       // GuestDetails.ConnectDatagrids(txtGuestID.Text);
                    }

                }
            }

            catch
                (Exception)
            {


            }

        }


        public void dgvRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RoomID = 0;
            decimal RoomCharge = 0;
            int RoomCapacity = 0;
            try
            {
                RoomID = (int) dgvRooms.Rows[e.RowIndex].Cells[0].Value;
                if (e.RowIndex >= 0)
                {
                    txtRoomId.Text = RoomID.ToString();

                    using (var context = new ManahauMotelEntities())
                    {
                        var cost =
                            context.Rooms.Where(r => r.RoomID == RoomID).Select(r => r.TariffCouple).FirstOrDefault();
                        var cost2 =
                            context.Rooms.Where(r => r.RoomID == RoomID)
                                .Select(r => r.TariffExtraPeople)
                                .FirstOrDefault();

                        int guestNumber = Convert.ToInt32(txtNumGuests.Text);
                        txtCostForRoom.Text = Convert.ToString(cost);

                        RoomCharge = BillingOperations.ChargeForExtras(guestNumber, cost, cost2);

                        txtCostForRoom.Text =  Convert.ToString(RoomCharge);
                        txtRoomCharge.Text = Convert.ToString(RoomCharge);

                    }
                }

            }
            catch
                (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // int GuestID = 0;

            DialogResult dialogueResult = MessageBox.Show("Would you like to modify this guest's details?", "",
                MessageBoxButtons.YesNo);
            if (dialogueResult == DialogResult.Yes)


                if (txtNotes.Text != string.Empty)
                {
                    GuestDetails.UpdateGuest();
                }

            try
            {
                GuestID = (int) dgvGuests.Rows[e.RowIndex].Cells[0].Value;
                txtGuestID.Text = dgvGuests.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvGuests.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dgvGuests.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dgvGuests.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNotes.Text = dgvGuests.Rows[e.RowIndex].Cells[4].Value.ToString();

                //if (e.RowIndex >= 0)
                //{

                //    txtGuestID.Text =  GuestID.ToString();


                //}

            }
            catch (Exception ex)
            {


            }
        }



        public void UpdateGuest()
        {
            // int ID = Convert.ToInt32(txtGuestID.Text);
            using (var context = new ManahauMotelEntities())
            {
                var guest = context.Guests.FirstOrDefault(g => g.GuestID == GuestID);
                
                if (guest != null)
                {


                    guest.GuestID = Convert.ToInt32(txtGuestID.Text);
                    guest.Name = txtName.Text;
                    guest.Address = txtAddress.Text;
                    guest.Phone = txtPhone.Text;
                    // guest.No_ofGuests = Convert.ToInt32(txtNumGuests.Text);
                    guest.Notes = txtNotes.Text;
                }
                //context.Guests.Add(guest);
                context.SaveChanges();
                ClearGuesttxtboxes();
                // GuestDetails.Allguests();

            }
        }

        public DataGridView AvailableRooms()
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

       

       
        private void btnShowBills_Click(object sender, EventArgs e)
        {
           //DataLoading.BillForGuest();
        }

      
    }

}
       
    
