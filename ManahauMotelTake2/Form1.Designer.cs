using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ManahauMotelTake2.Properties;

namespace ManahauMotelTake2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.btnTodaysReservations = new System.Windows.Forms.Button();
            this.btnReservationsPending = new System.Windows.Forms.Button();
            this.btnCurrentGuests = new System.Windows.Forms.Button();
            this.btnAllReservations = new System.Windows.Forms.Button();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.lblBookTo = new System.Windows.Forms.Label();
            this.lblNumGuests = new System.Windows.Forms.Label();
            this.lblBookFrom = new System.Windows.Forms.Label();
            this.dtpBookedTo = new System.Windows.Forms.DateTimePicker();
            this.dtpBookFrom = new System.Windows.Forms.DateTimePicker();
            this.txtNumGuests = new System.Windows.Forms.TextBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.lbxRoomCost = new System.Windows.Forms.ListBox();
            this.lblRoomCost = new System.Windows.Forms.Label();
            this.txtCostForRoom = new System.Windows.Forms.TextBox();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.tabGuests = new System.Windows.Forms.TabPage();
            this.btnAllGuests = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblBookedTo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblBookedFrom = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBookedTo = new System.Windows.Forms.TextBox();
            this.txtBookedFrom = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.tbAccounts = new System.Windows.Forms.TabPage();
            this.btnShowBills = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtPhoneCharge = new System.Windows.Forms.TextBox();
            this.txtBarCharge = new System.Windows.Forms.TextBox();
            this.txtWiFi = new System.Windows.Forms.TextBox();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.pbMotel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRoom = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPayBill = new System.Windows.Forms.Button();
            this.lblRoomCharge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.tabRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.tabGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.tbAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabReservations);
            this.tabControl1.Controls.Add(this.tabRooms);
            this.tabControl1.Controls.Add(this.tabGuests);
            this.tabControl1.Controls.Add(this.tbAccounts);
            this.tabControl1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 139);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1319, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabReservations
            // 
            this.tabReservations.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabReservations.Controls.Add(this.label1);
            this.tabReservations.Controls.Add(this.txtBookingID);
            this.tabReservations.Controls.Add(this.btnTodaysReservations);
            this.tabReservations.Controls.Add(this.btnReservationsPending);
            this.tabReservations.Controls.Add(this.btnCurrentGuests);
            this.tabReservations.Controls.Add(this.btnAllReservations);
            this.tabReservations.Controls.Add(this.btnSelectRoom);
            this.tabReservations.Controls.Add(this.lblBookTo);
            this.tabReservations.Controls.Add(this.lblNumGuests);
            this.tabReservations.Controls.Add(this.lblBookFrom);
            this.tabReservations.Controls.Add(this.dtpBookedTo);
            this.tabReservations.Controls.Add(this.dtpBookFrom);
            this.tabReservations.Controls.Add(this.txtNumGuests);
            this.tabReservations.Controls.Add(this.dgvReservations);
            this.tabReservations.ForeColor = System.Drawing.Color.Black;
            this.tabReservations.Location = new System.Drawing.Point(4, 28);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(1311, 528);
            this.tabReservations.TabIndex = 0;
            this.tabReservations.Text = "Reservations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1229, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(1232, 482);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(56, 26);
            this.txtBookingID.TabIndex = 28;
            // 
            // btnTodaysReservations
            // 
            this.btnTodaysReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnTodaysReservations.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodaysReservations.Location = new System.Drawing.Point(723, 394);
            this.btnTodaysReservations.Name = "btnTodaysReservations";
            this.btnTodaysReservations.Size = new System.Drawing.Size(253, 66);
            this.btnTodaysReservations.TabIndex = 25;
            this.btnTodaysReservations.Text = "Today\'s Reservations";
            this.btnTodaysReservations.UseVisualStyleBackColor = false;
            this.btnTodaysReservations.Click += new System.EventHandler(this.btnTodaysReservations_Click);
            // 
            // btnReservationsPending
            // 
            this.btnReservationsPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnReservationsPending.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationsPending.Location = new System.Drawing.Point(1024, 302);
            this.btnReservationsPending.Name = "btnReservationsPending";
            this.btnReservationsPending.Size = new System.Drawing.Size(253, 66);
            this.btnReservationsPending.TabIndex = 24;
            this.btnReservationsPending.Text = "Reservations Pending";
            this.btnReservationsPending.UseVisualStyleBackColor = false;
            this.btnReservationsPending.Click += new System.EventHandler(this.btnReservationsPending_Click);
            // 
            // btnCurrentGuests
            // 
            this.btnCurrentGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnCurrentGuests.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentGuests.Location = new System.Drawing.Point(723, 302);
            this.btnCurrentGuests.Name = "btnCurrentGuests";
            this.btnCurrentGuests.Size = new System.Drawing.Size(253, 66);
            this.btnCurrentGuests.TabIndex = 23;
            this.btnCurrentGuests.Text = "Current Guests";
            this.btnCurrentGuests.UseVisualStyleBackColor = false;
            this.btnCurrentGuests.Click += new System.EventHandler(this.btnCurrentGuests_Click);
            // 
            // btnAllReservations
            // 
            this.btnAllReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnAllReservations.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllReservations.Location = new System.Drawing.Point(1024, 392);
            this.btnAllReservations.Name = "btnAllReservations";
            this.btnAllReservations.Size = new System.Drawing.Size(253, 66);
            this.btnAllReservations.TabIndex = 22;
            this.btnAllReservations.Text = "All Reservations";
            this.btnAllReservations.UseVisualStyleBackColor = false;
            this.btnAllReservations.Click += new System.EventHandler(this.btnAllReservations_Click);
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSelectRoom.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectRoom.Location = new System.Drawing.Point(430, 319);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(253, 121);
            this.btnSelectRoom.TabIndex = 19;
            this.btnSelectRoom.Text = "Select Room";
            this.btnSelectRoom.UseVisualStyleBackColor = false;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // lblBookTo
            // 
            this.lblBookTo.AutoSize = true;
            this.lblBookTo.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTo.Location = new System.Drawing.Point(40, 356);
            this.lblBookTo.Name = "lblBookTo";
            this.lblBookTo.Size = new System.Drawing.Size(99, 24);
            this.lblBookTo.TabIndex = 18;
            this.lblBookTo.Text = "Book To";
            // 
            // lblNumGuests
            // 
            this.lblNumGuests.AutoSize = true;
            this.lblNumGuests.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGuests.Location = new System.Drawing.Point(41, 436);
            this.lblNumGuests.Name = "lblNumGuests";
            this.lblNumGuests.Size = new System.Drawing.Size(150, 24);
            this.lblNumGuests.TabIndex = 12;
            this.lblNumGuests.Text = "No. of Guests";
            // 
            // lblBookFrom
            // 
            this.lblBookFrom.AutoSize = true;
            this.lblBookFrom.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookFrom.Location = new System.Drawing.Point(40, 294);
            this.lblBookFrom.Name = "lblBookFrom";
            this.lblBookFrom.Size = new System.Drawing.Size(134, 24);
            this.lblBookFrom.TabIndex = 17;
            this.lblBookFrom.Text = "Book From ";
            // 
            // dtpBookedTo
            // 
            this.dtpBookedTo.CalendarFont = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookedTo.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookedTo.Location = new System.Drawing.Point(42, 381);
            this.dtpBookedTo.Name = "dtpBookedTo";
            this.dtpBookedTo.Size = new System.Drawing.Size(362, 32);
            this.dtpBookedTo.TabIndex = 8;
            this.dtpBookedTo.ValueChanged += new System.EventHandler(this.dtpBookedTo_ValueChanged);
            // 
            // dtpBookFrom
            // 
            this.dtpBookFrom.CalendarFont = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookFrom.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookFrom.Location = new System.Drawing.Point(42, 319);
            this.dtpBookFrom.Name = "dtpBookFrom";
            this.dtpBookFrom.Size = new System.Drawing.Size(362, 32);
            this.dtpBookFrom.TabIndex = 7;
            this.dtpBookFrom.ValueChanged += new System.EventHandler(this.dtpBookFrom_ValueChanged);
            // 
            // txtNumGuests
            // 
            this.txtNumGuests.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGuests.Location = new System.Drawing.Point(44, 461);
            this.txtNumGuests.Name = "txtNumGuests";
            this.txtNumGuests.Size = new System.Drawing.Size(176, 32);
            this.txtNumGuests.TabIndex = 4;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvReservations.Location = new System.Drawing.Point(42, 6);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReservations.Size = new System.Drawing.Size(1247, 258);
            this.dgvReservations.TabIndex = 0;
            this.dgvReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellClick);
            // 
            // tabRooms
            // 
            this.tabRooms.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabRooms.Controls.Add(this.lbxRoomCost);
            this.tabRooms.Controls.Add(this.lblRoomCost);
            this.tabRooms.Controls.Add(this.txtCostForRoom);
            this.tabRooms.Controls.Add(this.btnBookRoom);
            this.tabRooms.Controls.Add(this.lblRoomID);
            this.tabRooms.Controls.Add(this.txtRoomId);
            this.tabRooms.Controls.Add(this.dgvRooms);
            this.tabRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabRooms.Location = new System.Drawing.Point(4, 28);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(1311, 528);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "Rooms";
            // 
            // lbxRoomCost
            // 
            this.lbxRoomCost.FormattingEnabled = true;
            this.lbxRoomCost.ItemHeight = 19;
            this.lbxRoomCost.Location = new System.Drawing.Point(866, 153);
            this.lbxRoomCost.Name = "lbxRoomCost";
            this.lbxRoomCost.Size = new System.Drawing.Size(355, 80);
            this.lbxRoomCost.TabIndex = 28;
            // 
            // lblRoomCost
            // 
            this.lblRoomCost.AutoSize = true;
            this.lblRoomCost.Location = new System.Drawing.Point(269, 396);
            this.lblRoomCost.Name = "lblRoomCost";
            this.lblRoomCost.Size = new System.Drawing.Size(131, 19);
            this.lblRoomCost.TabIndex = 27;
            this.lblRoomCost.Text = "Cost For Room";
            // 
            // txtCostForRoom
            // 
            this.txtCostForRoom.Location = new System.Drawing.Point(273, 415);
            this.txtCostForRoom.Name = "txtCostForRoom";
            this.txtCostForRoom.Size = new System.Drawing.Size(100, 26);
            this.txtCostForRoom.TabIndex = 26;
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnBookRoom.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.ForeColor = System.Drawing.Color.Black;
            this.btnBookRoom.Location = new System.Drawing.Point(484, 394);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(253, 99);
            this.btnBookRoom.TabIndex = 25;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Location = new System.Drawing.Point(74, 394);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(125, 19);
            this.lblRoomID.TabIndex = 24;
            this.lblRoomID.Text = "Selected Room";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(79, 415);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(117, 26);
            this.txtRoomId.TabIndex = 23;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(52, 43);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(778, 319);
            this.dgvRooms.TabIndex = 22;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            this.dgvRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellContentClick);
            // 
            // tabGuests
            // 
            this.tabGuests.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tabGuests.Controls.Add(this.btnAllGuests);
            this.tabGuests.Controls.Add(this.btnCancelBooking);
            this.tabGuests.Controls.Add(this.txtGuestID);
            this.tabGuests.Controls.Add(this.btnConfirm);
            this.tabGuests.Controls.Add(this.lblGuestID);
            this.tabGuests.Controls.Add(this.btnCheckOut);
            this.tabGuests.Controls.Add(this.btnCheckIn);
            this.tabGuests.Controls.Add(this.btnAddGuest);
            this.tabGuests.Controls.Add(this.dgvGuests);
            this.tabGuests.Controls.Add(this.lblPhone);
            this.tabGuests.Controls.Add(this.lblGuestName);
            this.tabGuests.Controls.Add(this.lblBookedTo);
            this.tabGuests.Controls.Add(this.lblAddress);
            this.tabGuests.Controls.Add(this.lblNotes);
            this.tabGuests.Controls.Add(this.lblBookedFrom);
            this.tabGuests.Controls.Add(this.txtName);
            this.tabGuests.Controls.Add(this.txtAddress);
            this.tabGuests.Controls.Add(this.txtBookedTo);
            this.tabGuests.Controls.Add(this.txtBookedFrom);
            this.tabGuests.Controls.Add(this.txtPhone);
            this.tabGuests.Controls.Add(this.txtNotes);
            this.tabGuests.Location = new System.Drawing.Point(4, 28);
            this.tabGuests.Name = "tabGuests";
            this.tabGuests.Padding = new System.Windows.Forms.Padding(3);
            this.tabGuests.Size = new System.Drawing.Size(1311, 528);
            this.tabGuests.TabIndex = 2;
            this.tabGuests.Text = "Guests";
            // 
            // btnAllGuests
            // 
            this.btnAllGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnAllGuests.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllGuests.Location = new System.Drawing.Point(1021, 65);
            this.btnAllGuests.Name = "btnAllGuests";
            this.btnAllGuests.Size = new System.Drawing.Size(164, 118);
            this.btnAllGuests.TabIndex = 30;
            this.btnAllGuests.Text = "All Guests";
            this.btnAllGuests.UseVisualStyleBackColor = false;
            this.btnAllGuests.Click += new System.EventHandler(this.btnAllGuests_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnCancelBooking.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBooking.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancelBooking.Location = new System.Drawing.Point(1043, 447);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(253, 66);
            this.btnCancelBooking.TabIndex = 26;
            this.btnCancelBooking.Text = "Cancel Reservation";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(945, 471);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(58, 26);
            this.txtGuestID.TabIndex = 29;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnConfirm.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(545, 395);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(253, 118);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Update Guest Details";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.Location = new System.Drawing.Point(943, 447);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(63, 15);
            this.lblGuestID.TabIndex = 28;
            this.lblGuestID.Text = "Guest ID";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(1122, 260);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(164, 118);
            this.btnCheckOut.TabIndex = 27;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(908, 260);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(164, 118);
            this.btnCheckIn.TabIndex = 26;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnAddGuest.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(533, 260);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(164, 118);
            this.btnAddGuest.TabIndex = 21;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // dgvGuests
            // 
            this.dgvGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGuests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(21, 20);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.Size = new System.Drawing.Size(899, 200);
            this.dgvGuests.TabIndex = 20;
            this.dgvGuests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuests_CellClick);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(39, 374);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 19);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(38, 279);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(54, 19);
            this.lblGuestName.TabIndex = 9;
            this.lblGuestName.Text = "Name";
            // 
            // lblBookedTo
            // 
            this.lblBookedTo.AutoSize = true;
            this.lblBookedTo.Location = new System.Drawing.Point(281, 359);
            this.lblBookedTo.Name = "lblBookedTo";
            this.lblBookedTo.Size = new System.Drawing.Size(95, 19);
            this.lblBookedTo.TabIndex = 14;
            this.lblBookedTo.Text = "Booked To";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(38, 326);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 19);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(41, 437);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(55, 19);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Notes";
            // 
            // lblBookedFrom
            // 
            this.lblBookedFrom.AutoSize = true;
            this.lblBookedFrom.Location = new System.Drawing.Point(281, 297);
            this.lblBookedFrom.Name = "lblBookedFrom";
            this.lblBookedFrom.Size = new System.Drawing.Size(119, 19);
            this.lblBookedFrom.TabIndex = 13;
            this.lblBookedFrom.Text = "Booked From";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(42, 297);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(42, 345);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(176, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // txtBookedTo
            // 
            this.txtBookedTo.Location = new System.Drawing.Point(284, 378);
            this.txtBookedTo.Name = "txtBookedTo";
            this.txtBookedTo.Size = new System.Drawing.Size(176, 26);
            this.txtBookedTo.TabIndex = 6;
            // 
            // txtBookedFrom
            // 
            this.txtBookedFrom.Location = new System.Drawing.Point(284, 319);
            this.txtBookedFrom.Name = "txtBookedFrom";
            this.txtBookedFrom.Size = new System.Drawing.Size(176, 26);
            this.txtBookedFrom.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(42, 393);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 26);
            this.txtPhone.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(42, 460);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(418, 60);
            this.txtNotes.TabIndex = 5;
            // 
            // tbAccounts
            // 
            this.tbAccounts.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tbAccounts.Controls.Add(this.label2);
            this.tbAccounts.Controls.Add(this.label5);
            this.tbAccounts.Controls.Add(this.label4);
            this.tbAccounts.Controls.Add(this.label3);
            this.tbAccounts.Controls.Add(this.lblRoomCharge);
            this.tbAccounts.Controls.Add(this.btnPayBill);
            this.tbAccounts.Controls.Add(this.btnShowBills);
            this.tbAccounts.Controls.Add(this.listBox1);
            this.tbAccounts.Controls.Add(this.txtGuestName);
            this.tbAccounts.Controls.Add(this.txtPhoneCharge);
            this.tbAccounts.Controls.Add(this.txtBarCharge);
            this.tbAccounts.Controls.Add(this.txtWiFi);
            this.tbAccounts.Controls.Add(this.txtRoomCharge);
            this.tbAccounts.Controls.Add(this.dgvBills);
            this.tbAccounts.Location = new System.Drawing.Point(4, 28);
            this.tbAccounts.Name = "tbAccounts";
            this.tbAccounts.Size = new System.Drawing.Size(1311, 528);
            this.tbAccounts.TabIndex = 3;
            this.tbAccounts.Text = "Accounts";
            // 
            // btnShowBills
            // 
            this.btnShowBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnShowBills.Location = new System.Drawing.Point(700, 48);
            this.btnShowBills.Name = "btnShowBills";
            this.btnShowBills.Size = new System.Drawing.Size(75, 79);
            this.btnShowBills.TabIndex = 7;
            this.btnShowBills.Text = "Show bills";
            this.btnShowBills.UseVisualStyleBackColor = false;
            this.btnShowBills.Click += new System.EventHandler(this.btnShowBills_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(928, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 308);
            this.listBox1.TabIndex = 6;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(64, 309);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(100, 26);
            this.txtGuestName.TabIndex = 5;
            // 
            // txtPhoneCharge
            // 
            this.txtPhoneCharge.Location = new System.Drawing.Point(411, 345);
            this.txtPhoneCharge.Name = "txtPhoneCharge";
            this.txtPhoneCharge.Size = new System.Drawing.Size(100, 26);
            this.txtPhoneCharge.TabIndex = 4;
            // 
            // txtBarCharge
            // 
            this.txtBarCharge.Location = new System.Drawing.Point(411, 313);
            this.txtBarCharge.Name = "txtBarCharge";
            this.txtBarCharge.Size = new System.Drawing.Size(100, 26);
            this.txtBarCharge.TabIndex = 3;
            // 
            // txtWiFi
            // 
            this.txtWiFi.Location = new System.Drawing.Point(411, 281);
            this.txtWiFi.Name = "txtWiFi";
            this.txtWiFi.Size = new System.Drawing.Size(100, 26);
            this.txtWiFi.TabIndex = 2;
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(411, 249);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.Size = new System.Drawing.Size(100, 26);
            this.txtRoomCharge.TabIndex = 1;
            // 
            // dgvBills
            // 
            this.dgvBills.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Location = new System.Drawing.Point(40, 48);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Size = new System.Drawing.Size(615, 155);
            this.dgvBills.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cooper Black", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(675, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(285, 122);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Manahau \r\nMotels";
            // 
            // pbMotel
            // 
            this.pbMotel.Image = global::ManahauMotelTake2.Properties.Resources.Motel;
            this.pbMotel.Location = new System.Drawing.Point(1049, 30);
            this.pbMotel.Name = "pbMotel";
            this.pbMotel.Size = new System.Drawing.Size(280, 118);
            this.pbMotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMotel.TabIndex = 1;
            this.pbMotel.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ManahauMotelTake2.Properties.Resources.imagesL84QKVW7;
            this.pictureBox1.Location = new System.Drawing.Point(377, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbRoom
            // 
            this.pbRoom.Image = global::ManahauMotelTake2.Properties.Resources.imagesN2ECWX1M;
            this.pbRoom.Location = new System.Drawing.Point(131, 17);
            this.pbRoom.Name = "pbRoom";
            this.pbRoom.Size = new System.Drawing.Size(192, 116);
            this.pbRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRoom.TabIndex = 0;
            this.pbRoom.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnPayBill
            // 
            this.btnPayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnPayBill.Location = new System.Drawing.Point(624, 255);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(80, 76);
            this.btnPayBill.TabIndex = 8;
            this.btnPayBill.Text = "Pay Bill";
            this.btnPayBill.UseVisualStyleBackColor = false;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // lblRoomCharge
            // 
            this.lblRoomCharge.AutoSize = true;
            this.lblRoomCharge.Location = new System.Drawing.Point(349, 252);
            this.lblRoomCharge.Name = "lblRoomCharge";
            this.lblRoomCharge.Size = new System.Drawing.Size(56, 19);
            this.lblRoomCharge.TabIndex = 9;
            this.lblRoomCharge.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "WiFi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Guest Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1350, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbMotel);
            this.Controls.Add(this.pbRoom);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabReservations.ResumeLayout(false);
            this.tabReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.tabRooms.ResumeLayout(false);
            this.tabRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.tabGuests.ResumeLayout(false);
            this.tabGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.tbAccounts.ResumeLayout(false);
            this.tbAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabReservations;
        private TabPage tabRooms;
        private PictureBox pbMotel;
        private PictureBox pbRoom;
        private Label lblName;
        private PictureBox pictureBox1;
        private DataGridView dgvRooms;
        private DataGridView dgvReservations;
        private DateTimePicker dtpBookedTo;
        private DateTimePicker dtpBookFrom;
        private TextBox txtBookedTo;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtNumGuests;
        private TextBox txtBookedFrom;
        private TextBox txtName;
        private Label lblBookedTo;
        private Label lblBookedFrom;
        private Label lblNumGuests;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblGuestName;
        private Label lblNotes;
        private TextBox txtNotes;
        private Label lblBookTo;
        private Label lblBookFrom;
        private Button btnSelectRoom;
        private DataGridView dgvGuests;
        private Button btnConfirm;
        private TabPage tabGuests;
        private Button btnAddGuest;
        private ErrorProvider errorProvider1;
        private Label lblRoomID;
        private TextBox txtRoomId;
        private Button btnBookRoom;
        private Button btnAllReservations;
        private Button btnReservationsPending;
        private Button btnCurrentGuests;
        private Button btnTodaysReservations;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private TextBox txtGuestID;
        private Label lblGuestID;
        private Label lblRoomCost;
        private TextBox txtCostForRoom;
        private Button btnCancelBooking;
        private TextBox txtBookingID;
        private Label label1;
        private ListBox lbxRoomCost;
        private Button btnAllGuests;
        private TabPage tbAccounts;
        private TextBox txtGuestName;
        private TextBox txtPhoneCharge;
        private TextBox txtBarCharge;
        private TextBox txtWiFi;
        private TextBox txtRoomCharge;
        private DataGridView dgvBills;
        private ListBox listBox1;
        private Button btnShowBills;
        private Button btnPayBill;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblRoomCharge;
    }
}

