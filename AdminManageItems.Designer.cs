using System.Numerics;

namespace ABC_Car_Traders
{
    partial class AdminManageItems
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
            ManageItemSaveChangesButon = new Button();
            ManageItemDeleteBtn = new Button();
            ManageItemVehiclePartTex = new Label();
            ManageItemItemNameBox = new TextBox();
            ManageItemItemNameTex = new Label();
            ManageItemItemPriceTex = new Label();
            ManageItemItemPriceBox = new TextBox();
            ManageItemItemBrandTex = new Label();
            ManageItemItemTypeTex = new Label();
            ManageItemItemPriceRangeTex = new Label();
            ManageItemItemConditionTex = new Label();
            ManageItemFuelTypeTex = new Label();
            ManageItemStatusTex = new Label();
            ManageItemMileageTex = new Label();
            ManageItemMileageBox = new TextBox();
            ManageItemDescriptionTxt = new Label();
            ManageItemDescriptionBox = new TextBox();
            ManageItemPictureBox = new PictureBox();
            AdminManageItemChangePicButon = new Button();
            AddItemDataGridView = new DataGridView();
            ManageItemModelYearBox = new TextBox();
            ManageItemModelYearTex = new Label();
            ManageItemItemCodeBox = new TextBox();
            AdminManageItemExitBtn = new Button();
            ManageItemVehiclePartBox = new TextBox();
            ManageItemBrandBox = new TextBox();
            ManageItemItemTypeBox = new TextBox();
            ManageItemPriceRangeBox = new TextBox();
            ManageItemConditionBox = new TextBox();
            ManageItemFuelTypeBox = new TextBox();
            ManageItemStatusBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ManageItemPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddItemDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ManageItemSaveChangesButon
            // 
            ManageItemSaveChangesButon.Location = new Point(68, 12);
            ManageItemSaveChangesButon.Name = "ManageItemSaveChangesButon";
            ManageItemSaveChangesButon.Size = new Size(112, 42);
            ManageItemSaveChangesButon.TabIndex = 2;
            ManageItemSaveChangesButon.Text = "Save Changes";
            ManageItemSaveChangesButon.UseVisualStyleBackColor = true;
            ManageItemSaveChangesButon.Click += ManageItemEditButon_Click;
            // 
            // ManageItemDeleteBtn
            // 
            ManageItemDeleteBtn.Location = new Point(202, 12);
            ManageItemDeleteBtn.Name = "ManageItemDeleteBtn";
            ManageItemDeleteBtn.Size = new Size(83, 25);
            ManageItemDeleteBtn.TabIndex = 3;
            ManageItemDeleteBtn.Text = "Delete";
            ManageItemDeleteBtn.UseVisualStyleBackColor = true;
            ManageItemDeleteBtn.Click += ManageItemDeleteBtn_Click;
            // 
            // ManageItemVehiclePartTex
            // 
            ManageItemVehiclePartTex.AutoSize = true;
            ManageItemVehiclePartTex.Location = new Point(41, 67);
            ManageItemVehiclePartTex.Name = "ManageItemVehiclePartTex";
            ManageItemVehiclePartTex.Size = new Size(87, 20);
            ManageItemVehiclePartTex.TabIndex = 4;
            ManageItemVehiclePartTex.Text = "Vehicle/Part";
            // 
            // ManageItemItemNameBox
            // 
            ManageItemItemNameBox.Location = new Point(134, 93);
            ManageItemItemNameBox.Name = "ManageItemItemNameBox";
            ManageItemItemNameBox.Size = new Size(239, 27);
            ManageItemItemNameBox.TabIndex = 6;
            // 
            // ManageItemItemNameTex
            // 
            ManageItemItemNameTex.AutoSize = true;
            ManageItemItemNameTex.Location = new Point(82, 96);
            ManageItemItemNameTex.Name = "ManageItemItemNameTex";
            ManageItemItemNameTex.Size = new Size(46, 25);
            ManageItemItemNameTex.TabIndex = 7;
            ManageItemItemNameTex.Text = "Name";
            ManageItemItemNameTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemPriceTex
            // 
            ManageItemItemPriceTex.AutoSize = true;
            ManageItemItemPriceTex.Location = new Point(90, 129);
            ManageItemItemPriceTex.Name = "ManageItemItemPriceTex";
            ManageItemItemPriceTex.Size = new Size(38, 25);
            ManageItemItemPriceTex.TabIndex = 8;
            ManageItemItemPriceTex.Text = "Price";
            ManageItemItemPriceTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemPriceBox
            // 
            ManageItemItemPriceBox.Location = new Point(134, 126);
            ManageItemItemPriceBox.Name = "ManageItemItemPriceBox";
            ManageItemItemPriceBox.Size = new Size(239, 27);
            ManageItemItemPriceBox.TabIndex = 9;
            // 
            // ManageItemItemBrandTex
            // 
            ManageItemItemBrandTex.AutoSize = true;
            ManageItemItemBrandTex.Location = new Point(83, 195);
            ManageItemItemBrandTex.Name = "ManageItemItemBrandTex";
            ManageItemItemBrandTex.Size = new Size(45, 25);
            ManageItemItemBrandTex.TabIndex = 10;
            ManageItemItemBrandTex.Text = "Brand";
            ManageItemItemBrandTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemTypeTex
            // 
            ManageItemItemTypeTex.AutoSize = true;
            ManageItemItemTypeTex.Location = new Point(90, 228);
            ManageItemItemTypeTex.Name = "ManageItemItemTypeTex";
            ManageItemItemTypeTex.Size = new Size(38, 25);
            ManageItemItemTypeTex.TabIndex = 12;
            ManageItemItemTypeTex.Text = "Type";
            ManageItemItemTypeTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemPriceRangeTex
            // 
            ManageItemItemPriceRangeTex.AutoSize = true;
            ManageItemItemPriceRangeTex.Location = new Point(42, 261);
            ManageItemItemPriceRangeTex.Name = "ManageItemItemPriceRangeTex";
            ManageItemItemPriceRangeTex.Size = new Size(86, 25);
            ManageItemItemPriceRangeTex.TabIndex = 14;
            ManageItemItemPriceRangeTex.Text = "Price Range";
            ManageItemItemPriceRangeTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemConditionTex
            // 
            ManageItemItemConditionTex.AutoSize = true;
            ManageItemItemConditionTex.Location = new Point(453, 67);
            ManageItemItemConditionTex.Name = "ManageItemItemConditionTex";
            ManageItemItemConditionTex.Size = new Size(72, 25);
            ManageItemItemConditionTex.TabIndex = 16;
            ManageItemItemConditionTex.Text = "Condition";
            ManageItemItemConditionTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemFuelTypeTex
            // 
            ManageItemFuelTypeTex.AutoSize = true;
            ManageItemFuelTypeTex.Location = new Point(453, 107);
            ManageItemFuelTypeTex.Name = "ManageItemFuelTypeTex";
            ManageItemFuelTypeTex.Size = new Size(71, 25);
            ManageItemFuelTypeTex.TabIndex = 18;
            ManageItemFuelTypeTex.Text = "Fuel Type";
            ManageItemFuelTypeTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemStatusTex
            // 
            ManageItemStatusTex.AutoSize = true;
            ManageItemStatusTex.Location = new Point(476, 150);
            ManageItemStatusTex.Name = "ManageItemStatusTex";
            ManageItemStatusTex.Size = new Size(48, 25);
            ManageItemStatusTex.TabIndex = 20;
            ManageItemStatusTex.Text = "Stutus";
            ManageItemStatusTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemMileageTex
            // 
            ManageItemMileageTex.AutoSize = true;
            ManageItemMileageTex.Location = new Point(431, 196);
            ManageItemMileageTex.Name = "ManageItemMileageTex";
            ManageItemMileageTex.Size = new Size(94, 25);
            ManageItemMileageTex.TabIndex = 22;
            ManageItemMileageTex.Text = "Mileage   km";
            ManageItemMileageTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemMileageBox
            // 
            ManageItemMileageBox.Location = new Point(531, 193);
            ManageItemMileageBox.Name = "ManageItemMileageBox";
            ManageItemMileageBox.Size = new Size(239, 27);
            ManageItemMileageBox.TabIndex = 23;
            // 
            // ManageItemDescriptionTxt
            // 
            ManageItemDescriptionTxt.AutoSize = true;
            ManageItemDescriptionTxt.Location = new Point(441, 258);
            ManageItemDescriptionTxt.Name = "ManageItemDescriptionTxt";
            ManageItemDescriptionTxt.Size = new Size(83, 25);
            ManageItemDescriptionTxt.TabIndex = 24;
            ManageItemDescriptionTxt.Text = "Descriotion";
            ManageItemDescriptionTxt.UseCompatibleTextRendering = true;
            // 
            // ManageItemDescriptionBox
            // 
            ManageItemDescriptionBox.Location = new Point(531, 236);
            ManageItemDescriptionBox.Multiline = true;
            ManageItemDescriptionBox.Name = "ManageItemDescriptionBox";
            ManageItemDescriptionBox.ScrollBars = ScrollBars.Vertical;
            ManageItemDescriptionBox.Size = new Size(239, 73);
            ManageItemDescriptionBox.TabIndex = 25;
            // 
            // ManageItemPictureBox
            // 
            ManageItemPictureBox.BackColor = SystemColors.ScrollBar;
            ManageItemPictureBox.BorderStyle = BorderStyle.Fixed3D;
            ManageItemPictureBox.Image = Properties.Resources.ImageCar;
            ManageItemPictureBox.Location = new Point(834, 60);
            ManageItemPictureBox.Name = "ManageItemPictureBox";
            ManageItemPictureBox.Size = new Size(290, 223);
            ManageItemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ManageItemPictureBox.TabIndex = 28;
            ManageItemPictureBox.TabStop = false;
            // 
            // AdminManageItemChangePicButon
            // 
            AdminManageItemChangePicButon.Location = new Point(920, 289);
            AdminManageItemChangePicButon.Name = "AdminManageItemChangePicButon";
            AdminManageItemChangePicButon.Size = new Size(149, 35);
            AdminManageItemChangePicButon.TabIndex = 29;
            AdminManageItemChangePicButon.Text = "Change Picture";
            AdminManageItemChangePicButon.UseVisualStyleBackColor = true;
            AdminManageItemChangePicButon.Click += AdminManageItemChangePicButon_Click_1;
            // 
            // AddItemDataGridView
            // 
            AddItemDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddItemDataGridView.Location = new Point(0, 330);
            AddItemDataGridView.Name = "AddItemDataGridView";
            AddItemDataGridView.ReadOnly = true;
            AddItemDataGridView.RowHeadersWidth = 45;
            AddItemDataGridView.Size = new Size(1245, 329);
            AddItemDataGridView.TabIndex = 0;
            // 
            // ManageItemModelYearBox
            // 
            ManageItemModelYearBox.Location = new Point(134, 159);
            ManageItemModelYearBox.Name = "ManageItemModelYearBox";
            ManageItemModelYearBox.Size = new Size(239, 27);
            ManageItemModelYearBox.TabIndex = 30;
            // 
            // ManageItemModelYearTex
            // 
            ManageItemModelYearTex.AutoSize = true;
            ManageItemModelYearTex.Location = new Point(45, 161);
            ManageItemModelYearTex.Name = "ManageItemModelYearTex";
            ManageItemModelYearTex.Size = new Size(83, 25);
            ManageItemModelYearTex.TabIndex = 31;
            ManageItemModelYearTex.Text = "Model Year";
            ManageItemModelYearTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemCodeBox
            // 
            ManageItemItemCodeBox.Location = new Point(380, 27);
            ManageItemItemCodeBox.Name = "ManageItemItemCodeBox";
            ManageItemItemCodeBox.Size = new Size(239, 27);
            ManageItemItemCodeBox.TabIndex = 32;
            // 
            // AdminManageItemExitBtn
            // 
            AdminManageItemExitBtn.Location = new Point(809, 16);
            AdminManageItemExitBtn.Name = "AdminManageItemExitBtn";
            AdminManageItemExitBtn.Size = new Size(83, 25);
            AdminManageItemExitBtn.TabIndex = 44;
            AdminManageItemExitBtn.Text = "Exit";
            AdminManageItemExitBtn.UseVisualStyleBackColor = true;
            AdminManageItemExitBtn.Click += AdminManageItemExitBtn_Click;
            // 
            // ManageItemVehiclePartBox
            // 
            ManageItemVehiclePartBox.Location = new Point(134, 60);
            ManageItemVehiclePartBox.Name = "ManageItemVehiclePartBox";
            ManageItemVehiclePartBox.Size = new Size(239, 27);
            ManageItemVehiclePartBox.TabIndex = 45;
            // 
            // ManageItemBrandBox
            // 
            ManageItemBrandBox.Location = new Point(134, 192);
            ManageItemBrandBox.Name = "ManageItemBrandBox";
            ManageItemBrandBox.Size = new Size(239, 27);
            ManageItemBrandBox.TabIndex = 46;
            // 
            // ManageItemItemTypeBox
            // 
            ManageItemItemTypeBox.Location = new Point(134, 228);
            ManageItemItemTypeBox.Name = "ManageItemItemTypeBox";
            ManageItemItemTypeBox.Size = new Size(239, 27);
            ManageItemItemTypeBox.TabIndex = 47;
            // 
            // ManageItemPriceRangeBox
            // 
            ManageItemPriceRangeBox.Location = new Point(134, 261);
            ManageItemPriceRangeBox.Name = "ManageItemPriceRangeBox";
            ManageItemPriceRangeBox.Size = new Size(239, 27);
            ManageItemPriceRangeBox.TabIndex = 48;
            // 
            // ManageItemConditionBox
            // 
            ManageItemConditionBox.Location = new Point(531, 64);
            ManageItemConditionBox.Name = "ManageItemConditionBox";
            ManageItemConditionBox.Size = new Size(239, 27);
            ManageItemConditionBox.TabIndex = 49;
            // 
            // ManageItemFuelTypeBox
            // 
            ManageItemFuelTypeBox.Location = new Point(531, 105);
            ManageItemFuelTypeBox.Name = "ManageItemFuelTypeBox";
            ManageItemFuelTypeBox.Size = new Size(238, 27);
            ManageItemFuelTypeBox.TabIndex = 50;
            // 
            // ManageItemStatusBox
            // 
            ManageItemStatusBox.Location = new Point(531, 147);
            ManageItemStatusBox.Name = "ManageItemStatusBox";
            ManageItemStatusBox.Size = new Size(238, 27);
            ManageItemStatusBox.TabIndex = 51;
            // 
            // AdminManageItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 721);
            Controls.Add(ManageItemStatusBox);
            Controls.Add(ManageItemFuelTypeBox);
            Controls.Add(ManageItemConditionBox);
            Controls.Add(ManageItemPriceRangeBox);
            Controls.Add(ManageItemItemTypeBox);
            Controls.Add(ManageItemBrandBox);
            Controls.Add(ManageItemVehiclePartBox);
            Controls.Add(AdminManageItemExitBtn);
            Controls.Add(ManageItemItemCodeBox);
            Controls.Add(ManageItemModelYearTex);
            Controls.Add(ManageItemModelYearBox);
            Controls.Add(AdminManageItemChangePicButon);
            Controls.Add(ManageItemPictureBox);
            Controls.Add(ManageItemDescriptionBox);
            Controls.Add(ManageItemDescriptionTxt);
            Controls.Add(ManageItemMileageBox);
            Controls.Add(ManageItemMileageTex);
            Controls.Add(ManageItemStatusTex);
            Controls.Add(ManageItemFuelTypeTex);
            Controls.Add(ManageItemItemConditionTex);
            Controls.Add(ManageItemItemPriceRangeTex);
            Controls.Add(ManageItemItemTypeTex);
            Controls.Add(ManageItemItemBrandTex);
            Controls.Add(ManageItemItemPriceBox);
            Controls.Add(ManageItemItemPriceTex);
            Controls.Add(ManageItemItemNameTex);
            Controls.Add(ManageItemItemNameBox);
            Controls.Add(ManageItemVehiclePartTex);
            Controls.Add(ManageItemDeleteBtn);
            Controls.Add(ManageItemSaveChangesButon);
            Controls.Add(AddItemDataGridView);
            Name = "AdminManageItems";
            Text = "AdminManageItems";
            Load += AdminManageItems_Load;
            ((System.ComponentModel.ISupportInitialize)ManageItemPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddItemDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ManageItemSaveChangesButon;
        private Button ManageItemDeleteBtn;
        private Label ManageItemVehiclePartTex;
        private TextBox ManageItemItemNameBox;
        private Label ManageItemItemNameTex;
        private Label ManageItemItemPriceTex;
        private TextBox ManageItemItemPriceBox;
        private Label ManageItemItemBrandTex;
        private Label ManageItemItemTypeTex;
        private Label ManageItemItemPriceRangeTex;
        private Label ManageItemItemConditionTex;
        private Label ManageItemFuelTypeTex;
        private Label ManageItemStatusTex;
        private Label ManageItemMileageTex;
        private TextBox ManageItemMileageBox;
        private Label ManageItemDescriptionTxt;
        private TextBox ManageItemDescriptionBox;
        private PictureBox ManageItemPictureBox;
        private Button AdminManageItemChangePicButon;
        private DataGridView AddItemDataGridView;
        private TextBox ManageItemModelYearBox;
        private Label ManageItemModelYearTex;
        private TextBox ManageItemItemCodeBox;
        private Button AdminManageItemExitBtn;
        private TextBox ManageItemVehiclePartBox;
        private TextBox ManageItemBrandBox;
        private TextBox ManageItemItemTypeBox;
        private TextBox ManageItemPriceRangeBox;
        private TextBox ManageItemConditionBox;
        private TextBox ManageItemFuelTypeBox;
        private TextBox ManageItemStatusBox;
    }
}
