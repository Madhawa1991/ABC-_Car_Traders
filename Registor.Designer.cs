namespace ABC_Car_Traders
{
    partial class Registor
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
            wellcome = new Label();
            InfoLabel = new Label();
            LoginNameLabel = new Label();
            LoginNIClabel = new Label();
            LoginAddressLabel = new Label();
            LoginTelephoneLabel = new Label();
            LoginRegistorButton = new Button();
            LoginExitButon = new Button();
            LoginPasswordLabel = new Label();
            LoginRePasswLabel = new Label();
            LoginInfoLink = new LinkLabel();
            RegistorNameTex = new TextBox();
            RegistorNICTex = new TextBox();
            RegistorAddressTex = new TextBox();
            RegistorTelephoneTex = new TextBox();
            RegistorPasswordTex = new TextBox();
            RegistorRePasswordTex = new TextBox();
            RegistorShowPW = new CheckBox();
            RegistorEmaillabel = new Label();
            LoginEmailText = new TextBox();
            SuspendLayout();
            // 
            // wellcome
            // 
            wellcome.AutoSize = true;
            wellcome.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wellcome.Location = new Point(152, 9);
            wellcome.Name = "wellcome";
            wellcome.Size = new Size(505, 48);
            wellcome.TabIndex = 0;
            wellcome.Text = "Welcome to ABC Car Traders";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoLabel.Location = new Point(256, 68);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(305, 25);
            InfoLabel.TabIndex = 1;
            InfoLabel.Text = "Please fill below detais to registor !";
            // 
            // LoginNameLabel
            // 
            LoginNameLabel.AutoSize = true;
            LoginNameLabel.Location = new Point(170, 143);
            LoginNameLabel.Name = "LoginNameLabel";
            LoginNameLabel.Size = new Size(45, 15);
            LoginNameLabel.TabIndex = 2;
            LoginNameLabel.Text = "Name :";
            // 
            // LoginNIClabel
            // 
            LoginNIClabel.AutoSize = true;
            LoginNIClabel.Location = new Point(170, 172);
            LoginNIClabel.Name = "LoginNIClabel";
            LoginNIClabel.Size = new Size(33, 15);
            LoginNIClabel.TabIndex = 3;
            LoginNIClabel.Text = "NIC :";
            // 
            // LoginAddressLabel
            // 
            LoginAddressLabel.AutoSize = true;
            LoginAddressLabel.Location = new Point(165, 205);
            LoginAddressLabel.Name = "LoginAddressLabel";
            LoginAddressLabel.Size = new Size(55, 15);
            LoginAddressLabel.TabIndex = 4;
            LoginAddressLabel.Text = "Address :";
            // 
            // LoginTelephoneLabel
            // 
            LoginTelephoneLabel.AutoSize = true;
            LoginTelephoneLabel.Location = new Point(153, 244);
            LoginTelephoneLabel.Name = "LoginTelephoneLabel";
            LoginTelephoneLabel.Size = new Size(67, 15);
            LoginTelephoneLabel.TabIndex = 5;
            LoginTelephoneLabel.Text = "Telephone :";
            // 
            // LoginRegistorButton
            // 
            LoginRegistorButton.Location = new Point(349, 307);
            LoginRegistorButton.Name = "LoginRegistorButton";
            LoginRegistorButton.Size = new Size(75, 23);
            LoginRegistorButton.TabIndex = 6;
            LoginRegistorButton.Text = "Registor";
            LoginRegistorButton.UseVisualStyleBackColor = true;
            LoginRegistorButton.Click += LoginRegistorButton_Click;
            // 
            // LoginExitButon
            // 
            LoginExitButon.Location = new Point(686, 405);
            LoginExitButon.Name = "LoginExitButon";
            LoginExitButon.Size = new Size(75, 23);
            LoginExitButon.TabIndex = 7;
            LoginExitButon.Text = "Exit";
            LoginExitButon.UseVisualStyleBackColor = true;
            LoginExitButon.Click += LoginExitButon_Click;
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Location = new Point(473, 151);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(63, 15);
            LoginPasswordLabel.TabIndex = 8;
            LoginPasswordLabel.Text = "Password :";
            // 
            // LoginRePasswLabel
            // 
            LoginRePasswLabel.AutoSize = true;
            LoginRePasswLabel.Location = new Point(457, 190);
            LoginRePasswLabel.Name = "LoginRePasswLabel";
            LoginRePasswLabel.Size = new Size(79, 15);
            LoginRePasswLabel.TabIndex = 9;
            LoginRePasswLabel.Text = "Re Password :";
            // 
            // LoginInfoLink
            // 
            LoginInfoLink.AutoSize = true;
            LoginInfoLink.Location = new Point(317, 354);
            LoginInfoLink.Name = "LoginInfoLink";
            LoginInfoLink.Size = new Size(154, 15);
            LoginInfoLink.TabIndex = 10;
            LoginInfoLink.TabStop = true;
            LoginInfoLink.Text = "Click here to know about us";
            LoginInfoLink.LinkClicked += LoginInfoLink_LinkClicked;
            // 
            // RegistorNameTex
            // 
            RegistorNameTex.Location = new Point(221, 140);
            RegistorNameTex.Name = "RegistorNameTex";
            RegistorNameTex.Size = new Size(100, 23);
            RegistorNameTex.TabIndex = 11;
            // 
            // RegistorNICTex
            // 
            RegistorNICTex.Location = new Point(221, 172);
            RegistorNICTex.Name = "RegistorNICTex";
            RegistorNICTex.Size = new Size(100, 23);
            RegistorNICTex.TabIndex = 12;
            // 
            // RegistorAddressTex
            // 
            RegistorAddressTex.Location = new Point(221, 202);
            RegistorAddressTex.Name = "RegistorAddressTex";
            RegistorAddressTex.Size = new Size(100, 23);
            RegistorAddressTex.TabIndex = 13;
            // 
            // RegistorTelephoneTex
            // 
            RegistorTelephoneTex.Location = new Point(221, 236);
            RegistorTelephoneTex.Name = "RegistorTelephoneTex";
            RegistorTelephoneTex.Size = new Size(100, 23);
            RegistorTelephoneTex.TabIndex = 14;
            // 
            // RegistorPasswordTex
            // 
            RegistorPasswordTex.Location = new Point(567, 143);
            RegistorPasswordTex.Name = "RegistorPasswordTex";
            RegistorPasswordTex.Size = new Size(100, 23);
            RegistorPasswordTex.TabIndex = 15;
            RegistorPasswordTex.PasswordChar = '*';
            // 
            // RegistorRePasswordTex
            // 
            RegistorRePasswordTex.Location = new Point(567, 187);
            RegistorRePasswordTex.Name = "RegistorRePasswordTex";
            RegistorRePasswordTex.Size = new Size(100, 23);
            RegistorRePasswordTex.TabIndex = 16;
            RegistorRePasswordTex.PasswordChar = '*';
            // 
            // RegistorShowPW
            // 
            RegistorShowPW.AutoSize = true;
            RegistorShowPW.Location = new Point(673, 168);
            RegistorShowPW.Name = "RegistorShowPW";
            RegistorShowPW.Size = new Size(113, 19);
            RegistorShowPW.TabIndex = 17;
            RegistorShowPW.Text = "Show Passwords";
            RegistorShowPW.UseVisualStyleBackColor = true;
            RegistorShowPW.CheckedChanged += RegistorShowPW_CheckedChanged;
            // 
            // RegistorEmaillabel
            // 
            RegistorEmaillabel.AutoSize = true;
            RegistorEmaillabel.Location = new Point(165, 279);
            RegistorEmaillabel.Name = "RegistorEmaillabel";
            RegistorEmaillabel.Size = new Size(42, 15);
            RegistorEmaillabel.TabIndex = 18;
            RegistorEmaillabel.Text = "Email :";
            // 
            // LoginEmailText
            // 
            LoginEmailText.Location = new Point(221, 271);
            LoginEmailText.Name = "LoginEmailText";
            LoginEmailText.Size = new Size(100, 23);
            LoginEmailText.TabIndex = 19;
            // 
            // Registor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginEmailText);
            Controls.Add(RegistorEmaillabel);
            Controls.Add(RegistorShowPW);
            Controls.Add(RegistorRePasswordTex);
            Controls.Add(RegistorPasswordTex);
            Controls.Add(RegistorTelephoneTex);
            Controls.Add(RegistorAddressTex);
            Controls.Add(RegistorNICTex);
            Controls.Add(RegistorNameTex);
            Controls.Add(LoginInfoLink);
            Controls.Add(LoginRePasswLabel);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginExitButon);
            Controls.Add(LoginRegistorButton);
            Controls.Add(LoginTelephoneLabel);
            Controls.Add(LoginAddressLabel);
            Controls.Add(LoginNIClabel);
            Controls.Add(LoginNameLabel);
            Controls.Add(InfoLabel);
            Controls.Add(wellcome);
            Name = "Registor";
            Text = "Registor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wellcome;
        private Label InfoLabel;
        private Label LoginNameLabel;
        private Label LoginNIClabel;
        private Label LoginAddressLabel;
        private Label LoginTelephoneLabel;
        private Button LoginRegistorButton;
        private Button button2;
        private Label LoginPasswordLabel;
        private Label LoginRePasswLabel;
        private Button LoginExitButon;
        private LinkLabel LoginInfoLink;
        private TextBox RegistorNameTex;
        private TextBox RegistorNICTex;
        private TextBox RegistorAddressTex;
        private TextBox RegistorTelephoneTex;
        private TextBox RegistorPasswordTex;
        private TextBox RegistorRePasswordTex;
        private CheckBox RegistorShowPW;
        private Label RegistorEmaillabel;
        private TextBox LoginEmailText;
    }
}