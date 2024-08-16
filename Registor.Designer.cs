using System;
using System.Windows.Forms;

namespace AdminDashboard
{
    public partial class AdminDashboard : Form
    {
        private Panel navigationPanel;
        private Button btnViewCustomers;
        private Button btnManageItems;
        private Button btnConfirmPendingOrders;
        private Button btnCompletedOrders;
        private Button btnReports;

        private Panel viewCustomersPanel;
        private Panel manageItemsPanel;
        private Panel confirmPendingOrdersPanel;
        private Panel completedOrdersPanel;
        private Panel reportsPanel;

        public AdminDashboard()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.ResumeLayout(false);
        }

        private void InitializeDashboard()
        {
            // Initialize navigation panel and buttons
            navigationPanel = new Panel() { Dock = DockStyle.Left, Width = 200, BackColor = System.Drawing.Color.LightGray };
            btnViewCustomers = new Button() { Text = "View Customers", Dock = DockStyle.Top };
            btnManageItems = new Button() { Text = "Manage Items", Dock = DockStyle.Top };
            btnConfirmPendingOrders = new Button() { Text = "Confirm Pending Orders", Dock = DockStyle.Top };
            btnCompletedOrders = new Button() { Text = "Completed Orders", Dock = DockStyle.Top };
            btnReports = new Button() { Text = "Reports", Dock = DockStyle.Top };

            // Add buttons to navigation panel
            navigationPanel.Controls.Add(btnReports);
            navigationPanel.Controls.Add(btnCompletedOrders);
            navigationPanel.Controls.Add(btnConfirmPendingOrders);
            navigationPanel.Controls.Add(btnManageItems);
            navigationPanel.Controls.Add(btnViewCustomers);

            // Initialize content panels
            viewCustomersPanel = new Panel() { Dock = DockStyle.Fill };
            manageItemsPanel = new Panel() { Dock = DockStyle.Fill };
            confirmPendingOrdersPanel = new Panel() { Dock = DockStyle.Fill };
            completedOrdersPanel = new Panel() { Dock = DockStyle.Fill };
            reportsPanel = new Panel() { Dock = DockStyle.Fill };

            // Add content panels to the form
            Controls.Add(reportsPanel);
            Controls.Add(completedOrdersPanel);
            Controls.Add(confirmPendingOrdersPanel);
            Controls.Add(manageItemsPanel);
            Controls.Add(viewCustomersPanel);
            Controls.Add(navigationPanel);

            // Set the default panel to be visible
            viewCustomersPanel.BringToFront();

            // Wire up button click events
            btnViewCustomers.Click += (sender, e) => ShowPanel(viewCustomersPanel);
            btnManageItems.Click += (sender, e) => ShowPanel(manageItemsPanel);
            btnConfirmPendingOrders.Click += (sender, e) => ShowPanel(confirmPendingOrdersPanel);
            btnCompletedOrders.Click += (sender, e) => ShowPanel(completedOrdersPanel);
            btnReports.Click += (sender, e) => ShowPanel(reportsPanel);

            // Initialize content for each panel
            InitializeViewCustomersPanel();
            InitializeManageItemsPanel();
            InitializeConfirmPendingOrdersPanel();
            InitializeCompletedOrdersPanel();
            InitializeReportsPanel();
        }

        private void ShowPanel(Panel panel)
        {
            panel.BringToFront();
        }

        private void InitializeViewCustomersPanel()
        {
            DataGridView dgvCustomers = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Sample data
            dgvCustomers.Columns.Add("ID", "ID");
            dgvCustomers.Columns.Add("Name", "Name");
            dgvCustomers.Columns.Add("Email", "Email");

            // Add sample rows
            dgvCustomers.Rows.Add("1", "John Doe", "john.doe@example.com");
            dgvCustomers.Rows.Add("2", "Jane Smith", "jane.smith@example.com");

            viewCustomersPanel.Controls.Add(dgvCustomers);
        }

        private void InitializeManageItemsPanel()
        {
            // Placeholder for manage items functionality
            Label lblManageItems = new Label() { Text = "Manage Items Section", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            manageItemsPanel.Controls.Add(lblManageItems);
        }

        private void InitializeConfirmPendingOrdersPanel()
        {
            // Placeholder for confirm pending orders functionality
            Label lblConfirmPendingOrders = new Label() { Text = "Confirm Pending Orders Section", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            confirmPendingOrdersPanel.Controls.Add(lblConfirmPendingOrders);
        }

        private void InitializeCompletedOrdersPanel()
        {
            // Placeholder for completed orders functionality
            Label lblCompletedOrders = new Label() { Text = "Completed Orders Section", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            completedOrdersPanel.Controls.Add(lblCompletedOrders);
        }

        private void InitializeReportsPanel()
        {
            // Placeholder for reports functionality
            Label lblReports = new Label() { Text = "Reports Section", Dock = DockStyle.Fill, TextAlign = System.Drawing.ContentAlignment.MiddleCenter };
            reportsPanel.Controls.Add(lblReports);
        }
    }
}
