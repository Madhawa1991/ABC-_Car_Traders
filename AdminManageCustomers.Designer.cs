namespace ABC_Car_Traders
{
    partial class AdminManageCustomers
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
            AdminManageCustomerNameBox = new TextBox();
            AdminManageCustomerNICBox = new TextBox();
            AdminManageCustomersTelephoneBox = new TextBox();
            AdminManageCustomersEmailBox = new TextBox();
            AdminManageCustomerNameLabel = new Label();
            AdminManageCustomerEmailLabel = new Label();
            AdminManageCustomerTelephoneLabel = new Label();
            AdminManageCustomerAddressLabel = new Label();
            AdminManageCustomerNICLabel = new Label();
            AdminManageCustomerRolelLabel = new Label();
            AdminManageCustomerAddressBox = new TextBox();
            AdminManageCustomersRoleBox = new ComboBox();
            AdminManageCustomerGridView = new Zuby.ADGV.AdvancedDataGridView();
            AdminMangeCustomersSearchBox = new TextBox();
            AdminMangeCustomerSearchBtn = new Button();
            AdminManageCustomerSearchClearBtn = new Button();
            AdminMangeCustomerDeleteBtn = new Button();
            AdminManageCustomerStatusLabel = new Label();
            AdminMangeCustomerStatusBox = new ComboBox();
            AdminManageCustomerExitBtn = new Button();
            AdminManageCustomerUserIDbox = new TextBox();
            AdminMangeCustomerDeactiveBtn = new Button();
            AdminManageCustomerUpdateBtn = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)AdminManageCustomerGridView).BeginInit();
            SuspendLayout();
            // 
            // AdminManageCustomerNameBox
            // 
            AdminManageCustomerNameBox.Location = new Point(87, 12);
            AdminManageCustomerNameBox.Name = "AdminManageCustomerNameBox";
            AdminManageCustomerNameBox.Size = new Size(187, 27);
            AdminManageCustomerNameBox.TabIndex = 1;
            // 
            // AdminManageCustomerNICBox
            // 
            AdminManageCustomerNICBox.Location = new Point(90, 63);
            AdminManageCustomerNICBox.Name = "AdminManageCustomerNICBox";
            AdminManageCustomerNICBox.Size = new Size(184, 27);
            AdminManageCustomerNICBox.TabIndex = 2;
            // 
            // AdminManageCustomersTelephoneBox
            // 
            AdminManageCustomersTelephoneBox.Location = new Point(403, 9);
            AdminManageCustomersTelephoneBox.Name = "AdminManageCustomersTelephoneBox";
            AdminManageCustomersTelephoneBox.Size = new Size(178, 27);
            AdminManageCustomersTelephoneBox.TabIndex = 4;
            // 
            // AdminManageCustomersEmailBox
            // 
            AdminManageCustomersEmailBox.Location = new Point(384, 63);
            AdminManageCustomersEmailBox.Name = "AdminManageCustomersEmailBox";
            AdminManageCustomersEmailBox.Size = new Size(178, 27);
            AdminManageCustomersEmailBox.TabIndex = 5;
            // 
            // AdminManageCustomerNameLabel
            // 
            AdminManageCustomerNameLabel.AutoSize = true;
            AdminManageCustomerNameLabel.Location = new Point(23, 19);
            AdminManageCustomerNameLabel.Name = "AdminManageCustomerNameLabel";
            AdminManageCustomerNameLabel.Size = new Size(49, 20);
            AdminManageCustomerNameLabel.TabIndex = 6;
            AdminManageCustomerNameLabel.Text = "Name";
            // 
            // AdminManageCustomerEmailLabel
            // 
            AdminManageCustomerEmailLabel.AutoSize = true;
            AdminManageCustomerEmailLabel.Location = new Point(319, 70);
            AdminManageCustomerEmailLabel.Name = "AdminManageCustomerEmailLabel";
            AdminManageCustomerEmailLabel.Size = new Size(46, 20);
            AdminManageCustomerEmailLabel.TabIndex = 7;
            AdminManageCustomerEmailLabel.Text = "Email";
            // 
            // AdminManageCustomerTelephoneLabel
            // 
            AdminManageCustomerTelephoneLabel.AutoSize = true;
            AdminManageCustomerTelephoneLabel.Location = new Point(319, 12);
            AdminManageCustomerTelephoneLabel.Name = "AdminManageCustomerTelephoneLabel";
            AdminManageCustomerTelephoneLabel.Size = new Size(78, 20);
            AdminManageCustomerTelephoneLabel.TabIndex = 8;
            AdminManageCustomerTelephoneLabel.Text = "Telephone";
            // 
            // AdminManageCustomerAddressLabel
            // 
            AdminManageCustomerAddressLabel.AutoSize = true;
            AdminManageCustomerAddressLabel.Location = new Point(23, 133);
            AdminManageCustomerAddressLabel.Name = "AdminManageCustomerAddressLabel";
            AdminManageCustomerAddressLabel.Size = new Size(62, 20);
            AdminManageCustomerAddressLabel.TabIndex = 9;
            AdminManageCustomerAddressLabel.Text = "Address";
            // 
            // AdminManageCustomerNICLabel
            // 
            AdminManageCustomerNICLabel.AutoSize = true;
            AdminManageCustomerNICLabel.Location = new Point(23, 70);
            AdminManageCustomerNICLabel.Name = "AdminManageCustomerNICLabel";
            AdminManageCustomerNICLabel.Size = new Size(33, 20);
            AdminManageCustomerNICLabel.TabIndex = 10;
            AdminManageCustomerNICLabel.Text = "NIC";
            // 
            // AdminManageCustomerRolelLabel
            // 
            AdminManageCustomerRolelLabel.AutoSize = true;
            AdminManageCustomerRolelLabel.Location = new Point(326, 118);
            AdminManageCustomerRolelLabel.Name = "AdminManageCustomerRolelLabel";
            AdminManageCustomerRolelLabel.Size = new Size(39, 20);
            AdminManageCustomerRolelLabel.TabIndex = 11;
            AdminManageCustomerRolelLabel.Text = "Role";
            // 
            // AdminManageCustomerAddressBox
            // 
            AdminManageCustomerAddressBox.Location = new Point(91, 120);
            AdminManageCustomerAddressBox.Multiline = true;
            AdminManageCustomerAddressBox.Name = "AdminManageCustomerAddressBox";
            AdminManageCustomerAddressBox.ScrollBars = ScrollBars.Vertical;
            AdminManageCustomerAddressBox.Size = new Size(183, 73);
            AdminManageCustomerAddressBox.TabIndex = 26;
            // 
            // AdminManageCustomersRoleBox
            // 
            AdminManageCustomersRoleBox.FormattingEnabled = true;
            AdminManageCustomersRoleBox.Items.AddRange(new object[] { "Admin", "Customer" });
            AdminManageCustomersRoleBox.Location = new Point(384, 115);
            AdminManageCustomersRoleBox.Name = "AdminManageCustomersRoleBox";
            AdminManageCustomersRoleBox.Size = new Size(167, 28);
            AdminManageCustomersRoleBox.TabIndex = 27;
            // 
            // AdminManageCustomerGridView
            // 
            AdminManageCustomerGridView.AllowUserToAddRows = false;
            AdminManageCustomerGridView.AllowUserToDeleteRows = false;
            AdminManageCustomerGridView.AllowUserToResizeColumns = false;
            AdminManageCustomerGridView.AllowUserToResizeRows = false;
            AdminManageCustomerGridView.BackgroundColor = Color.FromArgb(192, 255, 255);
            AdminManageCustomerGridView.BorderStyle = BorderStyle.Fixed3D;
            AdminManageCustomerGridView.ColumnHeadersHeight = 25;
            AdminManageCustomerGridView.FilterAndSortEnabled = true;
            AdminManageCustomerGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            AdminManageCustomerGridView.Font = new Font("Microsoft Sans Serif", 6.792453F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminManageCustomerGridView.Location = new Point(-2, 249);
            AdminManageCustomerGridView.MaxFilterButtonImageHeight = 23;
            AdminManageCustomerGridView.Name = "AdminManageCustomerGridView";
            AdminManageCustomerGridView.ReadOnly = true;
            AdminManageCustomerGridView.RightToLeft = RightToLeft.No;
            AdminManageCustomerGridView.RowHeadersWidth = 45;
            AdminManageCustomerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AdminManageCustomerGridView.Size = new Size(940, 277);
            AdminManageCustomerGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            AdminManageCustomerGridView.TabIndex = 30;
            // 
            // AdminMangeCustomersSearchBox
            // 
            AdminMangeCustomersSearchBox.Location = new Point(23, 201);
            AdminMangeCustomersSearchBox.Name = "AdminMangeCustomersSearchBox";
            AdminMangeCustomersSearchBox.Size = new Size(539, 27);
            AdminMangeCustomersSearchBox.TabIndex = 31;
            // 
            // AdminMangeCustomerSearchBtn
            // 
            AdminMangeCustomerSearchBtn.BackColor = Color.FromArgb(0, 192, 0);
            AdminMangeCustomerSearchBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AdminMangeCustomerSearchBtn.Location = new Point(580, 196);
            AdminMangeCustomerSearchBtn.Name = "AdminMangeCustomerSearchBtn";
            AdminMangeCustomerSearchBtn.Size = new Size(88, 37);
            AdminMangeCustomerSearchBtn.TabIndex = 32;
            AdminMangeCustomerSearchBtn.Text = "Search";
            AdminMangeCustomerSearchBtn.UseVisualStyleBackColor = false;
            AdminMangeCustomerSearchBtn.Click += AdminMangeCustomerSearchBtn_Click;
            // 
            // AdminManageCustomerSearchClearBtn
            // 
            AdminManageCustomerSearchClearBtn.BackColor = Color.FromArgb(0, 192, 0);
            AdminManageCustomerSearchClearBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AdminManageCustomerSearchClearBtn.Location = new Point(682, 196);
            AdminManageCustomerSearchClearBtn.Name = "AdminManageCustomerSearchClearBtn";
            AdminManageCustomerSearchClearBtn.Size = new Size(88, 37);
            AdminManageCustomerSearchClearBtn.TabIndex = 33;
            AdminManageCustomerSearchClearBtn.Text = "Clear";
            AdminManageCustomerSearchClearBtn.UseVisualStyleBackColor = false;
            AdminManageCustomerSearchClearBtn.Click += AdminManageCustomerSearchClearBtn_Click;
            // 
            // AdminMangeCustomerDeleteBtn
            // 
            AdminMangeCustomerDeleteBtn.BackColor = Color.FromArgb(0, 192, 0);
            AdminMangeCustomerDeleteBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AdminMangeCustomerDeleteBtn.Location = new Point(580, 121);
            AdminMangeCustomerDeleteBtn.Name = "AdminMangeCustomerDeleteBtn";
            AdminMangeCustomerDeleteBtn.Size = new Size(88, 37);
            AdminMangeCustomerDeleteBtn.TabIndex = 34;
            AdminMangeCustomerDeleteBtn.Text = "Delete";
            AdminMangeCustomerDeleteBtn.UseVisualStyleBackColor = false;
            AdminMangeCustomerDeleteBtn.Click += AdminMangeCustomerDeleteBtn_Click;
            // 
            // AdminManageCustomerStatusLabel
            // 
            AdminManageCustomerStatusLabel.AutoSize = true;
            AdminManageCustomerStatusLabel.Location = new Point(326, 162);
            AdminManageCustomerStatusLabel.Name = "AdminManageCustomerStatusLabel";
            AdminManageCustomerStatusLabel.Size = new Size(49, 20);
            AdminManageCustomerStatusLabel.TabIndex = 36;
            AdminManageCustomerStatusLabel.Text = "Status";
            // 
            // AdminMangeCustomerStatusBox
            // 
            AdminMangeCustomerStatusBox.FormattingEnabled = true;
            AdminMangeCustomerStatusBox.Items.AddRange(new object[] { "Active", "Deactivate" });
            AdminMangeCustomerStatusBox.Location = new Point(384, 162);
            AdminMangeCustomerStatusBox.Name = "AdminMangeCustomerStatusBox";
            AdminMangeCustomerStatusBox.Size = new Size(167, 28);
            AdminMangeCustomerStatusBox.TabIndex = 37;
            // 
            // AdminManageCustomerExitBtn
            // 
            AdminManageCustomerExitBtn.Location = new Point(792, 113);
            AdminManageCustomerExitBtn.Name = "AdminManageCustomerExitBtn";
            AdminManageCustomerExitBtn.Size = new Size(83, 25);
            AdminManageCustomerExitBtn.TabIndex = 38;
            AdminManageCustomerExitBtn.Text = "Exit";
            AdminManageCustomerExitBtn.UseVisualStyleBackColor = true;
            AdminManageCustomerExitBtn.Click += AdminManageCustomerExitBtn_Click;
            // 
            // AdminManageCustomerUserIDbox
            // 
            AdminManageCustomerUserIDbox.Location = new Point(660, 18);
            AdminManageCustomerUserIDbox.Name = "AdminManageCustomerUserIDbox";
            AdminManageCustomerUserIDbox.ReadOnly = true;
            AdminManageCustomerUserIDbox.Size = new Size(110, 27);
            AdminManageCustomerUserIDbox.TabIndex = 39;
            // 
            // AdminMangeCustomerDeactiveBtn
            // 
            AdminMangeCustomerDeactiveBtn.BackColor = Color.FromArgb(0, 192, 0);
            AdminMangeCustomerDeactiveBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AdminMangeCustomerDeactiveBtn.Location = new Point(682, 121);
            AdminMangeCustomerDeactiveBtn.Name = "AdminMangeCustomerDeactiveBtn";
            AdminMangeCustomerDeactiveBtn.Size = new Size(88, 37);
            AdminMangeCustomerDeactiveBtn.TabIndex = 40;
            AdminMangeCustomerDeactiveBtn.Text = "Deactive";
            AdminMangeCustomerDeactiveBtn.UseVisualStyleBackColor = false;
            AdminMangeCustomerDeactiveBtn.Click += AdminMangeCustomerDeactiveBtn_Click;
            // 
            // AdminManageCustomerUpdateBtn
            // 
            AdminManageCustomerUpdateBtn.BackColor = Color.FromArgb(0, 192, 0);
            AdminManageCustomerUpdateBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AdminManageCustomerUpdateBtn.Location = new Point(792, 162);
            AdminManageCustomerUpdateBtn.Name = "AdminManageCustomerUpdateBtn";
            AdminManageCustomerUpdateBtn.Size = new Size(88, 37);
            AdminManageCustomerUpdateBtn.TabIndex = 41;
            AdminManageCustomerUpdateBtn.Text = "Update";
            AdminManageCustomerUpdateBtn.UseVisualStyleBackColor = false;
            AdminManageCustomerUpdateBtn.Click += AdminManageCustomerUpdateBtn_Click;
            // 
            // AdminManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(933, 522);
            Controls.Add(AdminManageCustomerUpdateBtn);
            Controls.Add(AdminMangeCustomerDeactiveBtn);
            Controls.Add(AdminManageCustomerUserIDbox);
            Controls.Add(AdminManageCustomerExitBtn);
            Controls.Add(AdminMangeCustomerStatusBox);
            Controls.Add(AdminManageCustomerStatusLabel);
            Controls.Add(AdminMangeCustomerDeleteBtn);
            Controls.Add(AdminManageCustomerSearchClearBtn);
            Controls.Add(AdminMangeCustomerSearchBtn);
            Controls.Add(AdminMangeCustomersSearchBox);
            Controls.Add(AdminManageCustomerGridView);
            Controls.Add(AdminManageCustomersRoleBox);
            Controls.Add(AdminManageCustomerAddressBox);
            Controls.Add(AdminManageCustomerRolelLabel);
            Controls.Add(AdminManageCustomerNICLabel);
            Controls.Add(AdminManageCustomerAddressLabel);
            Controls.Add(AdminManageCustomerTelephoneLabel);
            Controls.Add(AdminManageCustomerEmailLabel);
            Controls.Add(AdminManageCustomerNameLabel);
            Controls.Add(AdminManageCustomersEmailBox);
            Controls.Add(AdminManageCustomersTelephoneBox);
            Controls.Add(AdminManageCustomerNICBox);
            Controls.Add(AdminManageCustomerNameBox);
            Name = "AdminManageCustomers";
            Text = "AdminManageCustomers";
            ((System.ComponentModel.ISupportInitialize)AdminManageCustomerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AdminManageCustomerNameBox;
        private TextBox AdminManageCustomerNICBox;
        private TextBox AdminManageCustomersTelephoneBox;
        private TextBox AdminManageCustomersEmailBox;
        private Label AdminManageCustomerNameLabel;
        private Label AdminManageCustomerEmailLabel;
        private Label AdminManageCustomerTelephoneLabel;
        private Label AdminManageCustomerAddressLabel;
        private Label AdminManageCustomerNICLabel;
        private Label AdminManageCustomerRolelLabel;
        private ListBox AdminManageCustomerAddrexBox;
        private TextBox AdminManageCustomerAddressBox;
        private ComboBox AdminManageCustomersRoleBox;
        private Zuby.ADGV.AdvancedDataGridView AdminManageCustomerGridView;
        private TextBox AdminMangeCustomersSearchBox;
        private Button AdminMangeCustomerSearchBtn;
        private Button AdminManageCustomerSearchClearBtn;
        private Button AdminMangeCustomerDeleteBtn;
        private Label AdminManageCustomerStatusLabel;
        private ComboBox AdminMangeCustomerStatusBox;
        private Button AdminManageCustomerExitBtn;
        private TextBox AdminManageCustomerUserIDbox;
        private Button AdminMangeCustomerDeactiveBtn;
        private Button AdminManageCustomerUpdateBtn;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}