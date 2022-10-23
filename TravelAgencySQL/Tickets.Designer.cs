namespace TravelAgencySQL
{
    partial class Tickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            System.Windows.Forms.Label iD_TicketLabel;
            System.Windows.Forms.Label checkInDateLabel;
            System.Windows.Forms.Label checkOutDateLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label iD_HotelLabel;
            System.Windows.Forms.Label iD_RecreationLabel;
            System.Windows.Forms.Label iD_Services1Label;
            System.Windows.Forms.Label iD_Services2Label;
            System.Windows.Forms.Label iD_Services3Label;
            System.Windows.Forms.Label iD_ClientsLabel;
            System.Windows.Forms.Label iD_EmployeesLabel;
            System.Windows.Forms.Label bookingNoteLabel;
            System.Windows.Forms.Label payment_noteLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new TravelAgencySQL.TravelAgencyDataSet();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TicketsTableAdapter();
            this.tableAdapterManager = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.ticketsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ticketsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TicketTextBox = new System.Windows.Forms.TextBox();
            this.checkInDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.iD_HotelTextBox = new System.Windows.Forms.TextBox();
            this.iD_RecreationTextBox = new System.Windows.Forms.TextBox();
            this.iD_Services1TextBox = new System.Windows.Forms.TextBox();
            this.iD_Services2TextBox = new System.Windows.Forms.TextBox();
            this.iD_Services3TextBox = new System.Windows.Forms.TextBox();
            this.iD_ClientsTextBox = new System.Windows.Forms.TextBox();
            this.iD_EmployeesTextBox = new System.Windows.Forms.TextBox();
            this.bookingNoteCheckBox = new System.Windows.Forms.CheckBox();
            this.payment_noteCheckBox = new System.Windows.Forms.CheckBox();
            iD_TicketLabel = new System.Windows.Forms.Label();
            checkInDateLabel = new System.Windows.Forms.Label();
            checkOutDateLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            iD_HotelLabel = new System.Windows.Forms.Label();
            iD_RecreationLabel = new System.Windows.Forms.Label();
            iD_Services1Label = new System.Windows.Forms.Label();
            iD_Services2Label = new System.Windows.Forms.Label();
            iD_Services3Label = new System.Windows.Forms.Label();
            iD_ClientsLabel = new System.Windows.Forms.Label();
            iD_EmployeesLabel = new System.Windows.Forms.Label();
            bookingNoteLabel = new System.Windows.Forms.Label();
            payment_noteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).BeginInit();
            this.ticketsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(297, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Путевки\"";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RecreationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticketsBindingNavigator
            // 
            this.ticketsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketsBindingNavigator.BindingSource = this.ticketsBindingSource;
            this.ticketsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticketsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ticketsBindingNavigatorSaveItem});
            this.ticketsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketsBindingNavigator.Name = "ticketsBindingNavigator";
            this.ticketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ticketsBindingNavigator.TabIndex = 1;
            this.ticketsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ticketsBindingNavigatorSaveItem
            // 
            this.ticketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBindingNavigatorSaveItem.Image")));
            this.ticketsBindingNavigatorSaveItem.Name = "ticketsBindingNavigatorSaveItem";
            this.ticketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ticketsBindingNavigatorSaveItem.Text = "Save Data";
            this.ticketsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketsBindingNavigatorSaveItem_Click);
            // 
            // iD_TicketLabel
            // 
            iD_TicketLabel.AutoSize = true;
            iD_TicketLabel.Location = new System.Drawing.Point(298, 66);
            iD_TicketLabel.Name = "iD_TicketLabel";
            iD_TicketLabel.Size = new System.Drawing.Size(54, 13);
            iD_TicketLabel.TabIndex = 2;
            iD_TicketLabel.Text = "ID Ticket:";
            // 
            // iD_TicketTextBox
            // 
            this.iD_TicketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Ticket", true));
            this.iD_TicketTextBox.Location = new System.Drawing.Point(358, 63);
            this.iD_TicketTextBox.Name = "iD_TicketTextBox";
            this.iD_TicketTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_TicketTextBox.TabIndex = 3;
            // 
            // checkInDateLabel
            // 
            checkInDateLabel.AutoSize = true;
            checkInDateLabel.Location = new System.Drawing.Point(273, 92);
            checkInDateLabel.Name = "checkInDateLabel";
            checkInDateLabel.Size = new System.Drawing.Size(79, 13);
            checkInDateLabel.TabIndex = 4;
            checkInDateLabel.Text = "Check In Date:";
            // 
            // checkInDateDateTimePicker
            // 
            this.checkInDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketsBindingSource, "CheckInDate", true));
            this.checkInDateDateTimePicker.Location = new System.Drawing.Point(358, 88);
            this.checkInDateDateTimePicker.Name = "checkInDateDateTimePicker";
            this.checkInDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.checkInDateDateTimePicker.TabIndex = 5;
            // 
            // checkOutDateLabel
            // 
            checkOutDateLabel.AutoSize = true;
            checkOutDateLabel.Location = new System.Drawing.Point(265, 120);
            checkOutDateLabel.Name = "checkOutDateLabel";
            checkOutDateLabel.Size = new System.Drawing.Size(87, 13);
            checkOutDateLabel.TabIndex = 6;
            checkOutDateLabel.Text = "Check Out Date:";
            // 
            // checkOutDateDateTimePicker
            // 
            this.checkOutDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketsBindingSource, "CheckOutDate", true));
            this.checkOutDateDateTimePicker.Location = new System.Drawing.Point(358, 114);
            this.checkOutDateDateTimePicker.Name = "checkOutDateDateTimePicker";
            this.checkOutDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.checkOutDateDateTimePicker.TabIndex = 7;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(298, 155);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 8;
            durationLabel.Text = "Duration:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(354, 152);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 20);
            this.durationTextBox.TabIndex = 9;
            // 
            // iD_HotelLabel
            // 
            iD_HotelLabel.AutoSize = true;
            iD_HotelLabel.Location = new System.Drawing.Point(303, 185);
            iD_HotelLabel.Name = "iD_HotelLabel";
            iD_HotelLabel.Size = new System.Drawing.Size(49, 13);
            iD_HotelLabel.TabIndex = 10;
            iD_HotelLabel.Text = "ID Hotel:";
            // 
            // iD_HotelTextBox
            // 
            this.iD_HotelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Hotel", true));
            this.iD_HotelTextBox.Location = new System.Drawing.Point(353, 182);
            this.iD_HotelTextBox.Name = "iD_HotelTextBox";
            this.iD_HotelTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_HotelTextBox.TabIndex = 11;
            // 
            // iD_RecreationLabel
            // 
            iD_RecreationLabel.AutoSize = true;
            iD_RecreationLabel.Location = new System.Drawing.Point(272, 222);
            iD_RecreationLabel.Name = "iD_RecreationLabel";
            iD_RecreationLabel.Size = new System.Drawing.Size(76, 13);
            iD_RecreationLabel.TabIndex = 12;
            iD_RecreationLabel.Text = "ID Recreation:";
            // 
            // iD_RecreationTextBox
            // 
            this.iD_RecreationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Recreation", true));
            this.iD_RecreationTextBox.Location = new System.Drawing.Point(354, 219);
            this.iD_RecreationTextBox.Name = "iD_RecreationTextBox";
            this.iD_RecreationTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_RecreationTextBox.TabIndex = 13;
            // 
            // iD_Services1Label
            // 
            iD_Services1Label.AutoSize = true;
            iD_Services1Label.Location = new System.Drawing.Point(277, 261);
            iD_Services1Label.Name = "iD_Services1Label";
            iD_Services1Label.Size = new System.Drawing.Size(71, 13);
            iD_Services1Label.TabIndex = 14;
            iD_Services1Label.Text = "ID Services1:";
            // 
            // iD_Services1TextBox
            // 
            this.iD_Services1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Services1", true));
            this.iD_Services1TextBox.Location = new System.Drawing.Point(354, 258);
            this.iD_Services1TextBox.Name = "iD_Services1TextBox";
            this.iD_Services1TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Services1TextBox.TabIndex = 15;
            // 
            // iD_Services2Label
            // 
            iD_Services2Label.AutoSize = true;
            iD_Services2Label.Location = new System.Drawing.Point(277, 299);
            iD_Services2Label.Name = "iD_Services2Label";
            iD_Services2Label.Size = new System.Drawing.Size(71, 13);
            iD_Services2Label.TabIndex = 16;
            iD_Services2Label.Text = "ID Services2:";
            // 
            // iD_Services2TextBox
            // 
            this.iD_Services2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Services2", true));
            this.iD_Services2TextBox.Location = new System.Drawing.Point(354, 296);
            this.iD_Services2TextBox.Name = "iD_Services2TextBox";
            this.iD_Services2TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Services2TextBox.TabIndex = 17;
            // 
            // iD_Services3Label
            // 
            iD_Services3Label.AutoSize = true;
            iD_Services3Label.Location = new System.Drawing.Point(273, 338);
            iD_Services3Label.Name = "iD_Services3Label";
            iD_Services3Label.Size = new System.Drawing.Size(71, 13);
            iD_Services3Label.TabIndex = 18;
            iD_Services3Label.Text = "ID Services3:";
            // 
            // iD_Services3TextBox
            // 
            this.iD_Services3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Services3", true));
            this.iD_Services3TextBox.Location = new System.Drawing.Point(350, 335);
            this.iD_Services3TextBox.Name = "iD_Services3TextBox";
            this.iD_Services3TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_Services3TextBox.TabIndex = 19;
            // 
            // iD_ClientsLabel
            // 
            iD_ClientsLabel.AutoSize = true;
            iD_ClientsLabel.Location = new System.Drawing.Point(289, 376);
            iD_ClientsLabel.Name = "iD_ClientsLabel";
            iD_ClientsLabel.Size = new System.Drawing.Size(55, 13);
            iD_ClientsLabel.TabIndex = 20;
            iD_ClientsLabel.Text = "ID Clients:";
            // 
            // iD_ClientsTextBox
            // 
            this.iD_ClientsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Clients", true));
            this.iD_ClientsTextBox.Location = new System.Drawing.Point(350, 373);
            this.iD_ClientsTextBox.Name = "iD_ClientsTextBox";
            this.iD_ClientsTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ClientsTextBox.TabIndex = 21;
            // 
            // iD_EmployeesLabel
            // 
            iD_EmployeesLabel.AutoSize = true;
            iD_EmployeesLabel.Location = new System.Drawing.Point(269, 418);
            iD_EmployeesLabel.Name = "iD_EmployeesLabel";
            iD_EmployeesLabel.Size = new System.Drawing.Size(75, 13);
            iD_EmployeesLabel.TabIndex = 22;
            iD_EmployeesLabel.Text = "ID Employees:";
            // 
            // iD_EmployeesTextBox
            // 
            this.iD_EmployeesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Employees", true));
            this.iD_EmployeesTextBox.Location = new System.Drawing.Point(350, 415);
            this.iD_EmployeesTextBox.Name = "iD_EmployeesTextBox";
            this.iD_EmployeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_EmployeesTextBox.TabIndex = 23;
            // 
            // bookingNoteLabel
            // 
            bookingNoteLabel.AutoSize = true;
            bookingNoteLabel.Location = new System.Drawing.Point(269, 456);
            bookingNoteLabel.Name = "bookingNoteLabel";
            bookingNoteLabel.Size = new System.Drawing.Size(75, 13);
            bookingNoteLabel.TabIndex = 24;
            bookingNoteLabel.Text = "Booking Note:";
            // 
            // bookingNoteCheckBox
            // 
            this.bookingNoteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ticketsBindingSource, "BookingNote", true));
            this.bookingNoteCheckBox.Location = new System.Drawing.Point(350, 451);
            this.bookingNoteCheckBox.Name = "bookingNoteCheckBox";
            this.bookingNoteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.bookingNoteCheckBox.TabIndex = 25;
            this.bookingNoteCheckBox.Text = "checkBox1";
            this.bookingNoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // payment_noteLabel
            // 
            payment_noteLabel.AutoSize = true;
            payment_noteLabel.Location = new System.Drawing.Point(265, 490);
            payment_noteLabel.Name = "payment_noteLabel";
            payment_noteLabel.Size = new System.Drawing.Size(75, 13);
            payment_noteLabel.TabIndex = 26;
            payment_noteLabel.Text = "Payment note:";
            // 
            // payment_noteCheckBox
            // 
            this.payment_noteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ticketsBindingSource, "Payment note", true));
            this.payment_noteCheckBox.Location = new System.Drawing.Point(346, 485);
            this.payment_noteCheckBox.Name = "payment_noteCheckBox";
            this.payment_noteCheckBox.Size = new System.Drawing.Size(104, 24);
            this.payment_noteCheckBox.TabIndex = 27;
            this.payment_noteCheckBox.Text = "checkBox1";
            this.payment_noteCheckBox.UseVisualStyleBackColor = true;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(payment_noteLabel);
            this.Controls.Add(this.payment_noteCheckBox);
            this.Controls.Add(bookingNoteLabel);
            this.Controls.Add(this.bookingNoteCheckBox);
            this.Controls.Add(iD_EmployeesLabel);
            this.Controls.Add(this.iD_EmployeesTextBox);
            this.Controls.Add(iD_ClientsLabel);
            this.Controls.Add(this.iD_ClientsTextBox);
            this.Controls.Add(iD_Services3Label);
            this.Controls.Add(this.iD_Services3TextBox);
            this.Controls.Add(iD_Services2Label);
            this.Controls.Add(this.iD_Services2TextBox);
            this.Controls.Add(iD_Services1Label);
            this.Controls.Add(this.iD_Services1TextBox);
            this.Controls.Add(iD_RecreationLabel);
            this.Controls.Add(this.iD_RecreationTextBox);
            this.Controls.Add(iD_HotelLabel);
            this.Controls.Add(this.iD_HotelTextBox);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(checkOutDateLabel);
            this.Controls.Add(this.checkOutDateDateTimePicker);
            this.Controls.Add(checkInDateLabel);
            this.Controls.Add(this.checkInDateDateTimePicker);
            this.Controls.Add(iD_TicketLabel);
            this.Controls.Add(this.iD_TicketTextBox);
            this.Controls.Add(this.ticketsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).EndInit();
            this.ticketsBindingNavigator.ResumeLayout(false);
            this.ticketsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private TravelAgencyDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ticketsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TicketTextBox;
        private System.Windows.Forms.DateTimePicker checkInDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateDateTimePicker;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox iD_HotelTextBox;
        private System.Windows.Forms.TextBox iD_RecreationTextBox;
        private System.Windows.Forms.TextBox iD_Services1TextBox;
        private System.Windows.Forms.TextBox iD_Services2TextBox;
        private System.Windows.Forms.TextBox iD_Services3TextBox;
        private System.Windows.Forms.TextBox iD_ClientsTextBox;
        private System.Windows.Forms.TextBox iD_EmployeesTextBox;
        private System.Windows.Forms.CheckBox bookingNoteCheckBox;
        private System.Windows.Forms.CheckBox payment_noteCheckBox;
    }
}