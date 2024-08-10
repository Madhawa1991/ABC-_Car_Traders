using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // null  values in username and password fields
            if (string.IsNullOrWhiteSpace(NameBox.Text))
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the entered password
            string hashedPassword = HashPassword(PasswordBox.Text);

            // Connect to DB
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM [customer] WHERE username=@username  password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", NameBox.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Use the hashed password
                    int count = (int)cmd.ExecuteScalar(); // Count the login attempts

                    if (count > 0)
                    {
                        // Successfully logged in message
                        MessageBox.Show("You have successfully logged in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Login failed message display
                        MessageBox.Show("Login unsuccessful. Please check your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            // password visibility
            if (ShowPasswordCheckBox.Checked)
            {
                PasswordBox.PasswordChar = '\0'; // Show password
            }
            else
            {
                PasswordBox.PasswordChar = '*'; // Hide password
            }
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            TextBox passwordBox = sender as TextBox;

            if (passwordBox != null)
            {
                // Set the PasswordChar property to mask the characters with '*'
                passwordBox.PasswordChar = '*';
            }
        }



        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // registor link click
            Registor registerForm = new Registor();
            registerForm.ShowDialog();
            this.Show();

        }


        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogoBox_Click(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hash = md5.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
        }

        private void ChangePasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // registor link click
            ChangePW ChanPW = new ChangePW();
            ChanPW.ShowDialog();
            this.Show();
        }
    }
}
