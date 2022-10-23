namespace TravelAgencySQL
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            System.Windows.Forms.Label iD_PostLabel;
            System.Windows.Forms.Label postNameLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label responsibilitiesLabel;
            System.Windows.Forms.Label requirementsLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.travelAgencyDataSet = new TravelAgencySQL.TravelAgencyDataSet();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.PostTableAdapter();
            this.tableAdapterManager = new TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager();
            this.postBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.postBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PostTextBox = new System.Windows.Forms.TextBox();
            this.postNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.responsibilitiesTextBox = new System.Windows.Forms.TextBox();
            this.requirementsTextBox = new System.Windows.Forms.TextBox();
            iD_PostLabel = new System.Windows.Forms.Label();
            postNameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            responsibilitiesLabel = new System.Windows.Forms.Label();
            requirementsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingNavigator)).BeginInit();
            this.postBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(275, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Должности\"";
            // 
            // travelAgencyDataSet
            // 
            this.travelAgencyDataSet.DataSetName = "TravelAgencyDataSet";
            this.travelAgencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.travelAgencyDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.PostTableAdapter = this.postTableAdapter;
            this.tableAdapterManager.RecreationTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelAgencySQL.TravelAgencyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // postBindingNavigator
            // 
            this.postBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.postBindingNavigator.BindingSource = this.postBindingSource;
            this.postBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.postBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.postBindingNavigatorSaveItem});
            this.postBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.postBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.postBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.postBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.postBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.postBindingNavigator.Name = "postBindingNavigator";
            this.postBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.postBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.postBindingNavigator.TabIndex = 1;
            this.postBindingNavigator.Text = "bindingNavigator1";
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
            // postBindingNavigatorSaveItem
            // 
            this.postBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.postBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postBindingNavigatorSaveItem.Image")));
            this.postBindingNavigatorSaveItem.Name = "postBindingNavigatorSaveItem";
            this.postBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.postBindingNavigatorSaveItem.Text = "Save Data";
            this.postBindingNavigatorSaveItem.Click += new System.EventHandler(this.postBindingNavigatorSaveItem_Click);
            // 
            // iD_PostLabel
            // 
            iD_PostLabel.AutoSize = true;
            iD_PostLabel.Location = new System.Drawing.Point(276, 66);
            iD_PostLabel.Name = "iD_PostLabel";
            iD_PostLabel.Size = new System.Drawing.Size(45, 13);
            iD_PostLabel.TabIndex = 2;
            iD_PostLabel.Text = "ID Post:";
            // 
            // iD_PostTextBox
            // 
            this.iD_PostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "ID_Post", true));
            this.iD_PostTextBox.Location = new System.Drawing.Point(327, 63);
            this.iD_PostTextBox.Name = "iD_PostTextBox";
            this.iD_PostTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PostTextBox.TabIndex = 3;
            // 
            // postNameLabel
            // 
            postNameLabel.AutoSize = true;
            postNameLabel.Location = new System.Drawing.Point(259, 98);
            postNameLabel.Name = "postNameLabel";
            postNameLabel.Size = new System.Drawing.Size(62, 13);
            postNameLabel.TabIndex = 4;
            postNameLabel.Text = "Post Name:";
            // 
            // postNameTextBox
            // 
            this.postNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "PostName", true));
            this.postNameTextBox.Location = new System.Drawing.Point(327, 95);
            this.postNameTextBox.Name = "postNameTextBox";
            this.postNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.postNameTextBox.TabIndex = 5;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(282, 133);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 6;
            salaryLabel.Text = "Salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(327, 130);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 7;
            // 
            // responsibilitiesLabel
            // 
            responsibilitiesLabel.AutoSize = true;
            responsibilitiesLabel.Location = new System.Drawing.Point(239, 166);
            responsibilitiesLabel.Name = "responsibilitiesLabel";
            responsibilitiesLabel.Size = new System.Drawing.Size(82, 13);
            responsibilitiesLabel.TabIndex = 8;
            responsibilitiesLabel.Text = "Responsibilities:";
            // 
            // responsibilitiesTextBox
            // 
            this.responsibilitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Responsibilities", true));
            this.responsibilitiesTextBox.Location = new System.Drawing.Point(327, 163);
            this.responsibilitiesTextBox.Name = "responsibilitiesTextBox";
            this.responsibilitiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.responsibilitiesTextBox.TabIndex = 9;
            // 
            // requirementsLabel
            // 
            requirementsLabel.AutoSize = true;
            requirementsLabel.Location = new System.Drawing.Point(246, 201);
            requirementsLabel.Name = "requirementsLabel";
            requirementsLabel.Size = new System.Drawing.Size(75, 13);
            requirementsLabel.TabIndex = 10;
            requirementsLabel.Text = "Requirements:";
            // 
            // requirementsTextBox
            // 
            this.requirementsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Requirements", true));
            this.requirementsTextBox.Location = new System.Drawing.Point(327, 198);
            this.requirementsTextBox.Name = "requirementsTextBox";
            this.requirementsTextBox.Size = new System.Drawing.Size(100, 20);
            this.requirementsTextBox.TabIndex = 11;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(requirementsLabel);
            this.Controls.Add(this.requirementsTextBox);
            this.Controls.Add(responsibilitiesLabel);
            this.Controls.Add(this.responsibilitiesTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(postNameLabel);
            this.Controls.Add(this.postNameTextBox);
            this.Controls.Add(iD_PostLabel);
            this.Controls.Add(this.iD_PostTextBox);
            this.Controls.Add(this.postBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Post";
            this.Text = "Post";
            this.Load += new System.EventHandler(this.Post_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingNavigator)).EndInit();
            this.postBindingNavigator.ResumeLayout(false);
            this.postBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TravelAgencyDataSet travelAgencyDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private TravelAgencyDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private TravelAgencyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton postBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PostTextBox;
        private System.Windows.Forms.TextBox postNameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox responsibilitiesTextBox;
        private System.Windows.Forms.TextBox requirementsTextBox;
    }
}