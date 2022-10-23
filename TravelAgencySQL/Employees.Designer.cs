namespace TravelAgencySQL
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            System.Windows.Forms.Label iD_EmployeesLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label pasportDataLabel;
            System.Windows.Forms.Label iD_PostLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new TravelAgencySQL.TravelAgencyDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_EmployeesTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.pasportDataTextBox = new System.Windows.Forms.TextBox();
            this.iD_PostTextBox = new System.Windows.Forms.TextBox();
            iD_EmployeesLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            pasportDataLabel = new System.Windows.Forms.Label();
            iD_PostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(298, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Сотрудники\"";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RecreationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeesBindingNavigatorSaveItem});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.employeesBindingNavigator.TabIndex = 1;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
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
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.employeesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // iD_EmployeesLabel
            // 
            iD_EmployeesLabel.AutoSize = true;
            iD_EmployeesLabel.Location = new System.Drawing.Point(299, 81);
            iD_EmployeesLabel.Name = "iD_EmployeesLabel";
            iD_EmployeesLabel.Size = new System.Drawing.Size(75, 13);
            iD_EmployeesLabel.TabIndex = 2;
            iD_EmployeesLabel.Text = "ID Employees:";
            // 
            // iD_EmployeesTextBox
            // 
            this.iD_EmployeesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ID_Employees", true));
            this.iD_EmployeesTextBox.Location = new System.Drawing.Point(380, 78);
            this.iD_EmployeesTextBox.Name = "iD_EmployeesTextBox";
            this.iD_EmployeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_EmployeesTextBox.TabIndex = 3;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(317, 113);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(380, 110);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(345, 145);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(380, 142);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 7;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(329, 174);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(380, 171);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 9;
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(332, 208);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(42, 13);
            adressLabel.TabIndex = 10;
            adressLabel.Text = "Adress:";
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(380, 205);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(100, 20);
            this.adressTextBox.TabIndex = 11;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(293, 237);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(380, 234);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 13;
            // 
            // pasportDataLabel
            // 
            pasportDataLabel.AutoSize = true;
            pasportDataLabel.Location = new System.Drawing.Point(302, 269);
            pasportDataLabel.Name = "pasportDataLabel";
            pasportDataLabel.Size = new System.Drawing.Size(72, 13);
            pasportDataLabel.TabIndex = 14;
            pasportDataLabel.Text = "Pasport Data:";
            // 
            // pasportDataTextBox
            // 
            this.pasportDataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PasportData", true));
            this.pasportDataTextBox.Location = new System.Drawing.Point(380, 266);
            this.pasportDataTextBox.Name = "pasportDataTextBox";
            this.pasportDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.pasportDataTextBox.TabIndex = 15;
            // 
            // iD_PostLabel
            // 
            iD_PostLabel.AutoSize = true;
            iD_PostLabel.Location = new System.Drawing.Point(329, 301);
            iD_PostLabel.Name = "iD_PostLabel";
            iD_PostLabel.Size = new System.Drawing.Size(45, 13);
            iD_PostLabel.TabIndex = 16;
            iD_PostLabel.Text = "ID Post:";
            // 
            // iD_PostTextBox
            // 
            this.iD_PostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ID_Post", true));
            this.iD_PostTextBox.Location = new System.Drawing.Point(380, 298);
            this.iD_PostTextBox.Name = "iD_PostTextBox";
            this.iD_PostTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PostTextBox.TabIndex = 17;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_PostLabel);
            this.Controls.Add(this.iD_PostTextBox);
            this.Controls.Add(pasportDataLabel);
            this.Controls.Add(this.pasportDataTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(iD_EmployeesLabel);
            this.Controls.Add(this.iD_EmployeesTextBox);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private TravelAgencyDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_EmployeesTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox pasportDataTextBox;
        private System.Windows.Forms.TextBox iD_PostTextBox;
    }
}