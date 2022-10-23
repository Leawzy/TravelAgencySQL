namespace TravelAgencySQL
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            System.Windows.Forms.Label iD_ServicesLabel;
            System.Windows.Forms.Label servicesNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new TravelAgencySQL.TravelAgencyDataSet();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.ServicesTableAdapter();
            this.tableAdapterManager = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.servicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.servicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ServicesTextBox = new System.Windows.Forms.TextBox();
            this.servicesNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            iD_ServicesLabel = new System.Windows.Forms.Label();
            servicesNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingNavigator)).BeginInit();
            this.servicesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(273, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Доп услуги\"";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RecreationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicesBindingNavigator
            // 
            this.servicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.servicesBindingNavigator.BindingSource = this.servicesBindingSource;
            this.servicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.servicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicesBindingNavigatorSaveItem});
            this.servicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.servicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicesBindingNavigator.Name = "servicesBindingNavigator";
            this.servicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.servicesBindingNavigator.TabIndex = 1;
            this.servicesBindingNavigator.Text = "bindingNavigator1";
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
            // servicesBindingNavigatorSaveItem
            // 
            this.servicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("servicesBindingNavigatorSaveItem.Image")));
            this.servicesBindingNavigatorSaveItem.Name = "servicesBindingNavigatorSaveItem";
            this.servicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.servicesBindingNavigatorSaveItem.Text = "Save Data";
            this.servicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicesBindingNavigatorSaveItem_Click);
            // 
            // iD_ServicesLabel
            // 
            iD_ServicesLabel.AutoSize = true;
            iD_ServicesLabel.Location = new System.Drawing.Point(274, 71);
            iD_ServicesLabel.Name = "iD_ServicesLabel";
            iD_ServicesLabel.Size = new System.Drawing.Size(65, 13);
            iD_ServicesLabel.TabIndex = 2;
            iD_ServicesLabel.Text = "ID Services:";
            // 
            // iD_ServicesTextBox
            // 
            this.iD_ServicesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "ID_Services", true));
            this.iD_ServicesTextBox.Location = new System.Drawing.Point(345, 68);
            this.iD_ServicesTextBox.Name = "iD_ServicesTextBox";
            this.iD_ServicesTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ServicesTextBox.TabIndex = 3;
            // 
            // servicesNameLabel
            // 
            servicesNameLabel.AutoSize = true;
            servicesNameLabel.Location = new System.Drawing.Point(257, 106);
            servicesNameLabel.Name = "servicesNameLabel";
            servicesNameLabel.Size = new System.Drawing.Size(82, 13);
            servicesNameLabel.TabIndex = 4;
            servicesNameLabel.Text = "Services Name:";
            // 
            // servicesNameTextBox
            // 
            this.servicesNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "ServicesName", true));
            this.servicesNameTextBox.Location = new System.Drawing.Point(345, 103);
            this.servicesNameTextBox.Name = "servicesNameTextBox";
            this.servicesNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.servicesNameTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(274, 141);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(343, 138);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(303, 175);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicesBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(343, 172);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(servicesNameLabel);
            this.Controls.Add(this.servicesNameTextBox);
            this.Controls.Add(iD_ServicesLabel);
            this.Controls.Add(this.iD_ServicesTextBox);
            this.Controls.Add(this.servicesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Services";
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingNavigator)).EndInit();
            this.servicesBindingNavigator.ResumeLayout(false);
            this.servicesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private TravelAgencyDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ServicesTextBox;
        private System.Windows.Forms.TextBox servicesNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}