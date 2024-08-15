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
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // PaswordLabel
            // 
            PaswordLabel.AutoSize = true;
            PaswordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            PaswordLabel.Location = new Point(235, 69);
            PaswordLabel.Name = "PaswordLabel";
            PaswordLabel.Size = new Size(84, 20);
            PaswordLabel.TabIndex = 1;
            PaswordLabel.Text = "Password :";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DeepSkyBlue;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(361, 119);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(107, 26);
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
            CancelButton.Location = new Point(361, 151);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(107, 27);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic);
            ShowPasswordCheckBox.Location = new Point(418, 95);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(98, 17);
            ShowPasswordCheckBox.TabIndex = 5;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.Location = new Point(321, 66);
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.PasswordChar = '*';
            LoginPasswordBox.Size = new Size(195, 23);
            LoginPasswordBox.TabIndex = 6;
            LoginPasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nameLabel.Location = new Point(260, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name :";
            nameLabel.Click += label1_Click;
            // 
            // LoginRegisterLink
            // 
            LoginRegisterLink.AutoSize = true;
            LoginRegisterLink.LinkColor = Color.DarkCyan;
            LoginRegisterLink.Location = new Point(361, 181);
            LoginRegisterLink.Name = "LoginRegisterLink";
            LoginRegisterLink.Size = new Size(113, 15);
            LoginRegisterLink.TabIndex = 9;
            LoginRegisterLink.TabStop = true;
            LoginRegisterLink.Text = "Register as new user";
            LoginRegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // LogoBox
            // 
            LogoBox.BackgroundImage = (Image)resources.GetObject("LogoBox.BackgroundImage");
            LogoBox.Location = new Point(-1, 20);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(220, 176);
            LogoBox.TabIndex = 10;
            LogoBox.TabStop = false;
            // 
            // LoginChangePW
            // 
            LoginChangePW.AutoSize = true;
            LoginChangePW.LinkColor = Color.Teal;
            LoginChangePW.Location = new Point(311, 95);
            LoginChangePW.Name = "LoginChangePW";
            LoginChangePW.Size = new Size(101, 15);
            LoginChangePW.TabIndex = 11;
            LoginChangePW.TabStop = true;
            LoginChangePW.Text = "Change Password";
            LoginChangePW.LinkClicked += LoginChangePWLink_LinkClicked;
            // 
            // LoginNameBox
            // 
            LoginNameBox.Location = new Point(321, 28);
            LoginNameBox.Name = "LoginNameBox";
            LoginNameBox.Size = new Size(195, 23);
            LoginNameBox.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(566, 207);
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
            Name = "LoginForm";
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
    }
}
