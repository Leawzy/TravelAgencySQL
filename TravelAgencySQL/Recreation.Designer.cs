namespace TravelAgencySQL
{
    partial class Recreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recreation));
            System.Windows.Forms.Label iD_RecreationLabel;
            System.Windows.Forms.Label recreationNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label restrictionsLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new TravelAgencySQL.TravelAgencyDataSet();
            this.recreationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recreationTableAdapter = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.RecreationTableAdapter();
            this.tableAdapterManager = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.recreationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.recreationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_RecreationTextBox = new System.Windows.Forms.TextBox();
            this.recreationNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.restrictionsTextBox = new System.Windows.Forms.TextBox();
            iD_RecreationLabel = new System.Windows.Forms.Label();
            recreationNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            restrictionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recreationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recreationBindingNavigator)).BeginInit();
            this.recreationBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Виды отдыха\"";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recreationBindingSource
            // 
            this.recreationBindingSource.DataMember = "Recreation";
            this.recreationBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // recreationTableAdapter
            // 
            this.recreationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = null;
            this.tableAdapterManager.RecreationTableAdapter = this.recreationTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // recreationBindingNavigator
            // 
            this.recreationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recreationBindingNavigator.BindingSource = this.recreationBindingSource;
            this.recreationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recreationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recreationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.recreationBindingNavigatorSaveItem});
            this.recreationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.recreationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recreationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recreationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recreationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recreationBindingNavigator.Name = "recreationBindingNavigator";
            this.recreationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recreationBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.recreationBindingNavigator.TabIndex = 1;
            this.recreationBindingNavigator.Text = "bindingNavigator1";
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
            // recreationBindingNavigatorSaveItem
            // 
            this.recreationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recreationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recreationBindingNavigatorSaveItem.Image")));
            this.recreationBindingNavigatorSaveItem.Name = "recreationBindingNavigatorSaveItem";
            this.recreationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.recreationBindingNavigatorSaveItem.Text = "Save Data";
            this.recreationBindingNavigatorSaveItem.Click += new System.EventHandler(this.recreationBindingNavigatorSaveItem_Click);
            // 
            // iD_RecreationLabel
            // 
            iD_RecreationLabel.AutoSize = true;
            iD_RecreationLabel.Location = new System.Drawing.Point(268, 73);
            iD_RecreationLabel.Name = "iD_RecreationLabel";
            iD_RecreationLabel.Size = new System.Drawing.Size(76, 13);
            iD_RecreationLabel.TabIndex = 2;
            iD_RecreationLabel.Text = "ID Recreation:";
            // 
            // iD_RecreationTextBox
            // 
            this.iD_RecreationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recreationBindingSource, "ID_Recreation", true));
            this.iD_RecreationTextBox.Location = new System.Drawing.Point(350, 70);
            this.iD_RecreationTextBox.Name = "iD_RecreationTextBox";
            this.iD_RecreationTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_RecreationTextBox.TabIndex = 3;
            // 
            // recreationNameLabel
            // 
            recreationNameLabel.AutoSize = true;
            recreationNameLabel.Location = new System.Drawing.Point(251, 108);
            recreationNameLabel.Name = "recreationNameLabel";
            recreationNameLabel.Size = new System.Drawing.Size(93, 13);
            recreationNameLabel.TabIndex = 4;
            recreationNameLabel.Text = "Recreation Name:";
            // 
            // recreationNameTextBox
            // 
            this.recreationNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recreationBindingSource, "RecreationName", true));
            this.recreationNameTextBox.Location = new System.Drawing.Point(350, 105);
            this.recreationNameTextBox.Name = "recreationNameTextBox";
            this.recreationNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.recreationNameTextBox.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(281, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recreationBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(350, 137);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // restrictionsLabel
            // 
            restrictionsLabel.AutoSize = true;
            restrictionsLabel.Location = new System.Drawing.Point(279, 172);
            restrictionsLabel.Name = "restrictionsLabel";
            restrictionsLabel.Size = new System.Drawing.Size(65, 13);
            restrictionsLabel.TabIndex = 8;
            restrictionsLabel.Text = "Restrictions:";
            // 
            // restrictionsTextBox
            // 
            this.restrictionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recreationBindingSource, "Restrictions", true));
            this.restrictionsTextBox.Location = new System.Drawing.Point(350, 169);
            this.restrictionsTextBox.Name = "restrictionsTextBox";
            this.restrictionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.restrictionsTextBox.TabIndex = 9;
            // 
            // Recreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(restrictionsLabel);
            this.Controls.Add(this.restrictionsTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(recreationNameLabel);
            this.Controls.Add(this.recreationNameTextBox);
            this.Controls.Add(iD_RecreationLabel);
            this.Controls.Add(this.iD_RecreationTextBox);
            this.Controls.Add(this.recreationBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Recreation";
            this.Text = "Recreation";
            this.Load += new System.EventHandler(this.Recreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recreationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recreationBindingNavigator)).EndInit();
            this.recreationBindingNavigator.ResumeLayout(false);
            this.recreationBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource recreationBindingSource;
        private TravelAgencyDataSetTableAdapters.RecreationTableAdapter recreationTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator recreationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton recreationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_RecreationTextBox;
        private System.Windows.Forms.TextBox recreationNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox restrictionsTextBox;
    }
}