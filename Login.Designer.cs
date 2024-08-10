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
            PasswordBox = new TextBox();
            NameBox = new TextBox();
            ChangePasswordLink = new LinkLabel();
            nameLabel = new Label();
            RegisterLink = new LinkLabel();
            LogoBox = new PictureBox();
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
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ShowPasswordCheckBox.Location = new Point(418, 95);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(98, 17);
            ShowPasswordCheckBox.TabIndex = 5;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(321, 66);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(195, 23);
            PasswordBox.TabIndex = 6;
            PasswordBox.UseSystemPasswordChar = true;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(321, 28);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(195, 23);
            NameBox.TabIndex = 7;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // ChangePasswordLink
            // 
            ChangePasswordLink.AutoSize = true;
            ChangePasswordLink.LinkColor = Color.DarkCyan;
            ChangePasswordLink.Location = new Point(311, 97);
            ChangePasswordLink.Name = "ChangePasswordLink";
            ChangePasswordLink.Size = new Size(101, 15);
            ChangePasswordLink.TabIndex = 8;
            ChangePasswordLink.TabStop = true;
            ChangePasswordLink.Text = "Change Password";
            ChangePasswordLink.LinkClicked += ChangePasswordLink_LinkClicked;
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
            // RegisterLink
            // 
            RegisterLink.AutoSize = true;
            RegisterLink.LinkColor = Color.DarkCyan;
            RegisterLink.Location = new Point(361, 181);
            RegisterLink.Name = "RegisterLink";
            RegisterLink.Size = new Size(113, 15);
            RegisterLink.TabIndex = 9;
            RegisterLink.TabStop = true;
            RegisterLink.Text = "Register as new user";
            RegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // LogoBox
            // 
            LogoBox.BackgroundImage = (Image)resources.GetObject("LogoBox.BackgroundImage");
            LogoBox.Location = new Point(-1, 20);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(220, 176);
            LogoBox.TabIndex = 10;
            LogoBox.TabStop = false;
            LogoBox.Click += LogoBox_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(566, 207);
            Controls.Add(LogoBox);
            Controls.Add(RegisterLink);
            Controls.Add(ChangePasswordLink);
            Controls.Add(NameBox);
            Controls.Add(PasswordBox);
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

        private Label nameLabel;
        private Button LoginButton;
        private Button CancelButton;
        private CheckBox ShowPasswordCheckBox;
        private TextBox PasswordBox;
        private TextBox NameBox;
        private LinkLabel ChangePasswordLink;
        private LinkLabel RegisterLink;
        private Label PaswordLabel;
        private PictureBox LogoBox;
    }
}
