namespace ABC_Car_Traders
{
    partial class AdminHome
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
            Admin = new Label();
            AdminManageItems = new Button();
            SearchItem = new Button();
            SuspendLayout();
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Location = new Point(330, 9);
            Admin.Name = "Admin";
            Admin.Size = new Size(79, 15);
            Admin.TabIndex = 0;
            Admin.Text = "Admin Home";
            // 
            // AdminManageItems
            // 
            AdminManageItems.Location = new Point(67, 60);
            AdminManageItems.Name = "AdminManageItems";
            AdminManageItems.Size = new Size(121, 26);
            AdminManageItems.TabIndex = 1;
            AdminManageItems.Text = "Manage Items";
            AdminManageItems.UseVisualStyleBackColor = true;
            // 
            // SearchItem
            // 
            SearchItem.Location = new Point(67, 92);
            SearchItem.Name = "SearchItem";
            SearchItem.Size = new Size(121, 26);
            SearchItem.TabIndex = 2;
            SearchItem.Text = "Search Item";
            SearchItem.UseVisualStyleBackColor = true;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchItem);
            Controls.Add(AdminManageItems);
            Controls.Add(Admin);
            Name = "AdminHome";
            Text = "AdminHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Admin;
        private Button AdminManageItems;
        private Button SearchItem;
    }
}