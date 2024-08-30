namespace ABC_Car_Traders
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            PaswordLabel = new Label();
            LoginButton = new Button();
            CancelButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            LoginPasswordBox = new TextBox();
            nameLabel = new Label();
            LoginRegisterLink = new LinkLabel();
            LogoBox = new PictureBox();
            LoginChangePW = new LinkLabel();
            LoginNameBox = new TextBox();
            TemporyPagetestButon = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // PaswordLabel
            // 
            PaswordLabel.AutoSize = true;
            PaswordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            PaswordLabel.Location = new Point(269, 92);
            PaswordLabel.Name = "PaswordLabel";
            PaswordLabel.Size = new Size(95, 23);
            PaswordLabel.TabIndex = 1;
            PaswordLabel.Text = "Password :";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DeepSkyBlue;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(413, 159);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(122, 35);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DeepSkyBlue;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.ForeColor = SystemColors.ActiveCaptionText;
            CancelButton.Location = new Point(413, 201);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(122, 36);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            ShowPasswordCheckBox.Location = new Point(478, 127);
            ShowPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(112, 21);
            ShowPasswordCheckBox.TabIndex = 5;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.Location = new Point(367, 88);
            LoginPasswordBox.Margin = new Padding(3, 4, 3, 4);
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.PasswordChar = '*';
            LoginPasswordBox.Size = new Size(222, 27);
            LoginPasswordBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nameLabel.Location = new Point(297, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(67, 23);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name :";
            nameLabel.Click += label1_Click;
            // 
            // LoginRegisterLink
            // 
            LoginRegisterLink.AutoSize = true;
            LoginRegisterLink.LinkColor = Color.DarkCyan;
            LoginRegisterLink.Location = new Point(413, 241);
            LoginRegisterLink.Name = "LoginRegisterLink";
            LoginRegisterLink.Size = new Size(143, 20);
            LoginRegisterLink.TabIndex = 9;
            LoginRegisterLink.TabStop = true;
            LoginRegisterLink.Text = "Register as new user";
            LoginRegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // LogoBox
            // 
            LogoBox.BackgroundImage = (Image)resources.GetObject("LogoBox.BackgroundImage");
            LogoBox.Location = new Point(-1, 27);
            LogoBox.Margin = new Padding(3, 4, 3, 4);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(251, 235);
            LogoBox.TabIndex = 10;
            LogoBox.TabStop = false;
            // 
            // LoginChangePW
            // 
            LoginChangePW.AutoSize = true;
            LoginChangePW.LinkColor = Color.Teal;
            LoginChangePW.Location = new Point(355, 127);
            LoginChangePW.Name = "LoginChangePW";
            LoginChangePW.Size = new Size(117, 20);
            LoginChangePW.TabIndex = 11;
            LoginChangePW.TabStop = true;
            LoginChangePW.Text = "Forget Password";
            LoginChangePW.LinkClicked += LoginChangePWLink_LinkClicked;
            // 
            // LoginNameBox
            // 
            LoginNameBox.Location = new Point(367, 37);
            LoginNameBox.Margin = new Padding(3, 4, 3, 4);
            LoginNameBox.Name = "LoginNameBox";
            LoginNameBox.Size = new Size(222, 27);
            LoginNameBox.TabIndex = 7;
            // 
            // TemporyPagetestButon
            // 
            TemporyPagetestButon.Location = new Point(271, 172);
            TemporyPagetestButon.Margin = new Padding(3, 4, 3, 4);
            TemporyPagetestButon.Name = "TemporyPagetestButon";
            TemporyPagetestButon.Size = new Size(86, 31);
            TemporyPagetestButon.TabIndex = 12;
            TemporyPagetestButon.Text = "Page test";
            TemporyPagetestButon.UseVisualStyleBackColor = true;
            TemporyPagetestButon.Click += TemporyPagetestButon_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(647, 276);
            ControlBox = false;
            Controls.Add(TemporyPagetestButon);
            Controls.Add(LoginChangePW);
            Controls.Add(LogoBox);
            Controls.Add(LoginRegisterLink);
            Controls.Add(LoginNameBox);
            Controls.Add(LoginPasswordBox);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(CancelButton);
            Controls.Add(LoginButton);
            Controls.Add(PaswordLabel);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.LinkLabel LoginRegisterLink;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.LinkLabel LoginChangePW;
        private System.Windows.Forms.TextBox LoginNameBox;
        private Button TemporyPagetestButon;
    }
}
