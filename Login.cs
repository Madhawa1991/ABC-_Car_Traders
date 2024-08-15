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
            // Perform any initialization tasks here if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Check for null values in username and password fields
            if (string.IsNullOrWhiteSpace(LoginNameBox.Text))
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(LoginPasswordBox.Text))
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the entered password
            string hashedPassword = HashPassword(LoginPasswordBox.Text);

            // Connect to the database
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM [customer] WHERE username=@username AND password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", LoginNameBox.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Use the hashed password
                    int count = (int)cmd.ExecuteScalar(); // Count the matching records

                    if (count > 0)
                    {
                        // Successfully logged in message
                        MessageBox.Show("You have successfully logged in.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Login failed message
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
            // Close the login form
            this.Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            LoginPasswordBox.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '*';
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

            // Open the registration form
            Registor registerForm = new Registor();
            registerForm.ShowDialog();

            // Show the login form again after registration form is closed
            this.Show();
        }

        private void LoginChangePWLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current login form

            ChangePassword changePassword = new ChangePassword(); 
            changePassword.ShowDialog(); 
            this.Show(); 
        }


        private string HashPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            using (var md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
