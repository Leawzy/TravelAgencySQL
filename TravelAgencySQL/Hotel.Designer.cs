namespace TravelAgencySQL
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            System.Windows.Forms.Label iD_HotelLabel;
            System.Windows.Forms.Label nameHotelLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label starsLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new TravelAgencySQL.TravelAgencyDataSet();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.HotelTableAdapter();
            this.tableAdapterManager = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.hotelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.hotelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_HotelTextBox = new System.Windows.Forms.TextBox();
            this.nameHotelTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.starsTextBox = new System.Windows.Forms.TextBox();
            iD_HotelLabel = new System.Windows.Forms.Label();
            nameHotelLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            starsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingNavigator)).BeginInit();
            this.hotelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(294, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Отели\"";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = this.hotelTableAdapter;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RecreationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hotelBindingNavigator
            // 
            this.hotelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotelBindingNavigator.BindingSource = this.hotelBindingSource;
            this.hotelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.hotelBindingNavigatorSaveItem});
            this.hotelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelBindingNavigator.Name = "hotelBindingNavigator";
            this.hotelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.hotelBindingNavigator.TabIndex = 1;
            this.hotelBindingNavigator.Text = "bindingNavigator1";
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
            // hotelBindingNavigatorSaveItem
            // 
            this.hotelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelBindingNavigatorSaveItem.Image")));
            this.hotelBindingNavigatorSaveItem.Name = "hotelBindingNavigatorSaveItem";
            this.hotelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.hotelBindingNavigatorSaveItem.Text = "Save Data";
            this.hotelBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotelBindingNavigatorSaveItem_Click);
            // 
            // iD_HotelLabel
            // 
            iD_HotelLabel.AutoSize = true;
            iD_HotelLabel.Location = new System.Drawing.Point(295, 70);
            iD_HotelLabel.Name = "iD_HotelLabel";
            iD_HotelLabel.Size = new System.Drawing.Size(49, 13);
            iD_HotelLabel.TabIndex = 2;
            iD_HotelLabel.Text = "ID Hotel:";
            // 
            // iD_HotelTextBox
            // 
            this.iD_HotelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "ID_Hotel", true));
            this.iD_HotelTextBox.Location = new System.Drawing.Point(350, 67);
            this.iD_HotelTextBox.Name = "iD_HotelTextBox";
            this.iD_HotelTextBox.Size = new System.Drawing.Size(145, 20);
            this.iD_HotelTextBox.TabIndex = 3;
            // 
            // nameHotelLabel
            // 
            nameHotelLabel.AutoSize = true;
            nameHotelLabel.Location = new System.Drawing.Point(278, 105);
            nameHotelLabel.Name = "nameHotelLabel";
            nameHotelLabel.Size = new System.Drawing.Size(66, 13);
            nameHotelLabel.TabIndex = 4;
            nameHotelLabel.Text = "Name Hotel:";
            // 
            // nameHotelTextBox
            // 
            this.nameHotelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "NameHotel", true));
            this.nameHotelTextBox.Location = new System.Drawing.Point(350, 102);
            this.nameHotelTextBox.Name = "nameHotelTextBox";
            this.nameHotelTextBox.Size = new System.Drawing.Size(145, 20);
            this.nameHotelTextBox.TabIndex = 5;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(298, 143);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 6;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(350, 140);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(145, 20);
            this.countryTextBox.TabIndex = 7;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(317, 180);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(350, 177);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(145, 20);
            this.cityTextBox.TabIndex = 9;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(263, 220);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(350, 217);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(145, 20);
            this.phoneNumberTextBox.TabIndex = 11;
            // 
            // starsLabel
            // 
            starsLabel.AutoSize = true;
            starsLabel.Location = new System.Drawing.Point(310, 255);
            starsLabel.Name = "starsLabel";
            starsLabel.Size = new System.Drawing.Size(34, 13);
            starsLabel.TabIndex = 12;
            starsLabel.Text = "Stars:";
            // 
            // starsTextBox
            // 
            this.starsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "Stars", true));
            this.starsTextBox.Location = new System.Drawing.Point(350, 252);
            this.starsTextBox.Name = "starsTextBox";
            this.starsTextBox.Size = new System.Drawing.Size(145, 20);
            this.starsTextBox.TabIndex = 13;
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(starsLabel);
            this.Controls.Add(this.starsTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(nameHotelLabel);
            this.Controls.Add(this.nameHotelTextBox);
            this.Controls.Add(iD_HotelLabel);
            this.Controls.Add(this.iD_HotelTextBox);
            this.Controls.Add(this.hotelBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.Hotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingNavigator)).EndInit();
            this.hotelBindingNavigator.ResumeLayout(false);
            this.hotelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private TravelAgencyDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton hotelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_HotelTextBox;
        private System.Windows.Forms.TextBox nameHotelTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox starsTextBox;
    }
}