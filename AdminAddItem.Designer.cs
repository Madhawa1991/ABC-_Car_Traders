namespace ABC_Car_Traders
{
    partial class AdminAddItem
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
            lblItemCode = new Label();
            AddItemNameBox = new TextBox();
            AddItemPriceBox = new NumericUpDown();
            AddItemModelYearBox = new NumericUpDown();
            AddItemBrandNamecmb = new ComboBox();
            AddItemTypecmb = new ComboBox();
            cmbPriceRange = new ComboBox();
            cmbCondition = new ComboBox();
            cmbFuelType = new ComboBox();
            cmbStates = new ComboBox();
            numMileage = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            AddItemVehicleradioButton = new RadioButton();
            AddradioButton1 = new RadioButton();
            AddItemNameTex = new Label();
            label1 = new Label();
            AddItemPriceTex = new Label();
            AddItemBrandTex = new Label();
            AddItemTypeTex = new Label();
            AddItemPriceRangeTex = new Label();
            AddItemConditionTex = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)AddItemPriceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddItemModelYearBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblItemCode
            // 
            lblItemCode.AutoSize = true;
            lblItemCode.Location = new Point(20, 20);
            lblItemCode.Name = "lblItemCode";
            lblItemCode.Size = new Size(65, 15);
            lblItemCode.TabIndex = 0;
            lblItemCode.Text = "Item Code:";
            // 
            // AddItemNameBox
            // 
            AddItemNameBox.Location = new Point(306, 48);
            AddItemNameBox.Name = "AddItemNameBox";
            AddItemNameBox.PlaceholderText = "Item Name";
            AddItemNameBox.Size = new Size(200, 23);
            AddItemNameBox.TabIndex = 1;
            // 
            // AddItemPriceBox
            // 
            AddItemPriceBox.DecimalPlaces = 2;
            AddItemPriceBox.Location = new Point(306, 77);
            AddItemPriceBox.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            AddItemPriceBox.Name = "AddItemPriceBox";
            AddItemPriceBox.Size = new Size(200, 23);
            AddItemPriceBox.TabIndex = 2;
            // 
            // AddItemModelYearBox
            // 
            AddItemModelYearBox.Location = new Point(306, 106);
            AddItemModelYearBox.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            AddItemModelYearBox.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            AddItemModelYearBox.Name = "AddItemModelYearBox";
            AddItemModelYearBox.Size = new Size(200, 23);
            AddItemModelYearBox.TabIndex = 3;
            AddItemModelYearBox.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // AddItemBrandNamecmb
            // 
            AddItemBrandNamecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemBrandNamecmb.Items.AddRange(new object[] { "Toyota", "Ford", "BMW" });
            AddItemBrandNamecmb.Location = new Point(306, 138);
            AddItemBrandNamecmb.Name = "AddItemBrandNamecmb";
            AddItemBrandNamecmb.Size = new Size(200, 23);
            AddItemBrandNamecmb.TabIndex = 4;
            // 
            // AddItemTypecmb
            // 
            AddItemTypecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemTypecmb.Items.AddRange(new object[] { "Car", "Van", "Bus", "Lorry" });
            AddItemTypecmb.Location = new Point(306, 172);
            AddItemTypecmb.Name = "AddItemTypecmb";
            AddItemTypecmb.Size = new Size(200, 23);
            AddItemTypecmb.TabIndex = 5;
            // 
            // cmbPriceRange
            // 
            cmbPriceRange.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriceRange.Items.AddRange(new object[] { "1-1,000,000", "1,000,001-2,500,000", "2,500,001-5,000,000", "5,000,001-10,000,000", "10,000,001-50,000,000", "50,000,000<" });
            cmbPriceRange.Location = new Point(306, 213);
            cmbPriceRange.Name = "cmbPriceRange";
            cmbPriceRange.Size = new Size(200, 23);
            cmbPriceRange.TabIndex = 6;
            // 
            // cmbCondition
            // 
            cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondition.Items.AddRange(new object[] { "Brand New", "Used" });
            cmbCondition.Location = new Point(306, 257);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(200, 23);
            cmbCondition.TabIndex = 7;
            // 
            // cmbFuelType
            // 
            cmbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFuelType.Items.AddRange(new object[] { "Petrol", "Diesel" });
            cmbFuelType.Location = new Point(306, 299);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(200, 23);
            cmbFuelType.TabIndex = 8;
            // 
            // cmbStates
            // 
            cmbStates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStates.Items.AddRange(new object[] { "Available", "Reserved", "Sold" });
            cmbStates.Location = new Point(306, 338);
            cmbStates.Name = "cmbStates";
            cmbStates.Size = new Size(200, 23);
            cmbStates.TabIndex = 9;
            // 
            // numMileage
            // 
            numMileage.Location = new Point(306, 375);
            numMileage.Name = "numMileage";
            numMileage.Size = new Size(200, 23);
            numMileage.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(306, 442);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(468, 442);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(531, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // AddItemVehicleradioButton
            // 
            AddItemVehicleradioButton.AutoSize = true;
            AddItemVehicleradioButton.Location = new Point(320, 16);
            AddItemVehicleradioButton.Name = "AddItemVehicleradioButton";
            AddItemVehicleradioButton.Size = new Size(62, 19);
            AddItemVehicleradioButton.TabIndex = 14;
            AddItemVehicleradioButton.TabStop = true;
            AddItemVehicleradioButton.Text = "Vehicle";
            AddItemVehicleradioButton.UseVisualStyleBackColor = true;
            // 
            // AddradioButton1
            // 
            AddradioButton1.AutoSize = true;
            AddradioButton1.Location = new Point(399, 16);
            AddradioButton1.Name = "AddradioButton1";
            AddradioButton1.Size = new Size(46, 19);
            AddradioButton1.TabIndex = 15;
            AddradioButton1.TabStop = true;
            AddradioButton1.Text = "Part";
            AddradioButton1.UseVisualStyleBackColor = true;
            // 
            // AddItemNameTex
            // 
            AddItemNameTex.AutoSize = true;
            AddItemNameTex.Location = new Point(221, 51);
            AddItemNameTex.Name = "AddItemNameTex";
            AddItemNameTex.Size = new Size(72, 15);
            AddItemNameTex.TabIndex = 16;
            AddItemNameTex.Text = "Item Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 79);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 17;
            label1.Text = "Item Price :";
            // 
            // AddItemPriceTex
            // 
            AddItemPriceTex.AutoSize = true;
            AddItemPriceTex.Location = new Point(221, 108);
            AddItemPriceTex.Name = "AddItemPriceTex";
            AddItemPriceTex.Size = new Size(39, 15);
            AddItemPriceTex.TabIndex = 18;
            AddItemPriceTex.Text = "Price :";
            // 
            // AddItemBrandTex
            // 
            AddItemBrandTex.AutoSize = true;
            AddItemBrandTex.Location = new Point(221, 141);
            AddItemBrandTex.Name = "AddItemBrandTex";
            AddItemBrandTex.Size = new Size(44, 15);
            AddItemBrandTex.TabIndex = 19;
            AddItemBrandTex.Text = "Brand :";
            // 
            // AddItemTypeTex
            // 
            AddItemTypeTex.AutoSize = true;
            AddItemTypeTex.Location = new Point(221, 175);
            AddItemTypeTex.Name = "AddItemTypeTex";
            AddItemTypeTex.Size = new Size(37, 15);
            AddItemTypeTex.TabIndex = 20;
            AddItemTypeTex.Text = "Type :";
            // 
            // AddItemPriceRangeTex
            // 
            AddItemPriceRangeTex.AutoSize = true;
            AddItemPriceRangeTex.Location = new Point(218, 216);
            AddItemPriceRangeTex.Name = "AddItemPriceRangeTex";
            AddItemPriceRangeTex.Size = new Size(75, 15);
            AddItemPriceRangeTex.TabIndex = 21;
            AddItemPriceRangeTex.Text = "Price Range :";
            // 
            // AddItemConditionTex
            // 
            AddItemConditionTex.AutoSize = true;
            AddItemConditionTex.Location = new Point(221, 260);
            AddItemConditionTex.Name = "AddItemConditionTex";
            AddItemConditionTex.Size = new Size(66, 15);
            AddItemConditionTex.TabIndex = 22;
            AddItemConditionTex.Text = "Condition :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 302);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 23;
            label7.Text = "label1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(221, 338);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 24;
            label8.Text = "label1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(221, 377);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 25;
            label9.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(611, 442);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Save";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(531, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 184);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(592, 338);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 28;
            label10.Text = "label1";
            // 
            // AdminAddItem
            // 
            ClientSize = new Size(742, 506);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(AddItemConditionTex);
            Controls.Add(AddItemPriceRangeTex);
            Controls.Add(AddItemTypeTex);
            Controls.Add(AddItemBrandTex);
            Controls.Add(AddItemPriceTex);
            Controls.Add(label1);
            Controls.Add(AddItemNameTex);
            Controls.Add(AddradioButton1);
            Controls.Add(AddItemVehicleradioButton);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblItemCode);
            Controls.Add(AddItemNameBox);
            Controls.Add(AddItemPriceBox);
            Controls.Add(AddItemModelYearBox);
            Controls.Add(AddItemBrandNamecmb);
            Controls.Add(AddItemTypecmb);
            Controls.Add(cmbPriceRange);
            Controls.Add(cmbCondition);
            Controls.Add(cmbFuelType);
            Controls.Add(cmbStates);
            Controls.Add(numMileage);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AdminAddItem";
            Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)AddItemPriceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddItemModelYearBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMileage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemCode;
        private TextBox AddItemNameBox;
        private NumericUpDown AddItemPriceBox;
        private NumericUpDown AddItemModelYearBox;
        private ComboBox AddItemBrandNamecmb;
        private ComboBox AddItemTypecmb;
        private ComboBox cmbPriceRange;
        private ComboBox cmbCondition;
        private ComboBox cmbFuelType;
        private ComboBox cmbStates;
        private NumericUpDown numMileage;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private RadioButton AddItemVehicleradioButton;
        private RadioButton AddradioButton1;
        private Label AddItemNameTex;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label10;
        private Label AddItemPriceTex;
        private Label AddItemBrandTex;
        private Label AddItemTypeTex;
        private Label AddItemPriceRangeTex;
        private Label AddItemConditionTex;
    }
}
