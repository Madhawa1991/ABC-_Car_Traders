using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminManageItems : Form
    {
        private bool isDataChanged = false; // Flag to track if data has changed

        public AdminManageItems()
        {
            InitializeComponent();
            LoadData();
            AddItemDataGridView.CellClick += AddItemDataGridView_CellClick;

            // Subscribe to change events for text boxes and combo boxes
            ManageItemItemNameBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemItemPriceBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemVehiclePartBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemItemTypeBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemPriceRangeBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemConditionBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemFuelTypeBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemStatusBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemMileageBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemDescriptionBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemModelYearBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemBrandBox.TextChanged += (s, e) => isDataChanged = true;
        }

        private void LoadData() // Load all items from the Item table into the DataGridView
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                string query = "SELECT * FROM Item";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    AddItemDataGridView.DataSource = dt;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) // Load selected row data into the form fields
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure the row index is valid
                {
                    DataGridViewRow row = AddItemDataGridView.Rows[e.RowIndex];

                    // Load the data from the selected row into the text boxes
                    ManageItemItemCodeBox.Text = row.Cells["ItemCode"].Value.ToString(); // Item code is the primary key, not allowed to edit
                    ManageItemVehiclePartBox.Text = row.Cells["Vehicle/Part"].Value.ToString();
                    ManageItemItemNameBox.Text = row.Cells["ItemName"].Value.ToString();
                    ManageItemItemPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value).ToString("F2"); // Convert to decimal and two decimal places
                    ManageItemItemTypeBox.Text = row.Cells["Type"].Value.ToString();
                    ManageItemPriceRangeBox.Text = row.Cells["PriceRange"].Value.ToString();
                    ManageItemConditionBox.Text = row.Cells["Condition"].Value.ToString();
                    ManageItemFuelTypeBox.Text = row.Cells["FuelType"].Value.ToString();
                    ManageItemStatusBox.Text = row.Cells["Status"].Value.ToString();
                    ManageItemMileageBox.Text = row.Cells["Mileage"].Value.ToString();
                    ManageItemDescriptionBox.Text = row.Cells["Description"].Value.ToString();
                    ManageItemModelYearBox.Text = row.Cells["ModelYear"].Value.ToString();
                    ManageItemBrandBox.Text = row.Cells["Brand"].Value.ToString();

                    // Load the image into the PictureBox
                    if (row.Cells["ItemImage"].Value != DBNull.Value) // Check if there is an image
                    {
                        byte[] imageBytes = (byte[])row.Cells["ItemImage"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            ManageItemPictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        ManageItemPictureBox.Image = null; // Clear PictureBox if there's no image
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageItemEditButon_Click(object sender, EventArgs e) // Update the selected item in the database
        {
            if (!isDataChanged)
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Item SET ItemName = @ItemName, ItemPrice = @ItemPrice, Type = @Type, PriceRange = @PriceRange, Condition = @Condition, FuelType = @FuelType, Status = @Status, Mileage = @Mileage, Description = @Description, ModelYear = @ModelYear, Brand = @Brand, ItemImage = @ItemImage WHERE ItemCode = @ItemCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ItemCode", ManageItemItemCodeBox.Text);
                        cmd.Parameters.AddWithValue("@ItemName", ManageItemItemNameBox.Text);
                        cmd.Parameters.AddWithValue("@ItemPrice",ManageItemItemPriceBox.Text);
                        cmd.Parameters.AddWithValue("@Type", ManageItemItemTypeBox.Text);
                        cmd.Parameters.AddWithValue("@PriceRange", ManageItemPriceRangeBox.Text);
                        cmd.Parameters.AddWithValue("@Condition", ManageItemConditionBox.Text);
                        cmd.Parameters.AddWithValue("@FuelType", ManageItemFuelTypeBox.Text);
                        cmd.Parameters.AddWithValue("@Status", ManageItemStatusBox.Text);
                        cmd.Parameters.AddWithValue("@Mileage", ManageItemMileageBox.Text);
                        cmd.Parameters.AddWithValue("@Description", ManageItemDescriptionBox.Text);
                        cmd.Parameters.AddWithValue("@ModelYear", ManageItemModelYearBox.Text);
                        cmd.Parameters.AddWithValue("@Brand", ManageItemBrandBox.Text);

                        // Save the image
                        if (ManageItemPictureBox.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                ManageItemPictureBox.Image.Save(ms, ManageItemPictureBox.Image.RawFormat);
                                byte[] imageBytes = ms.ToArray();
                                cmd.Parameters.AddWithValue("@ItemImage", imageBytes);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ItemImage", DBNull.Value);
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Reload the DataGridView to reflect the changes
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            isDataChanged = false; // Reset the flag after saving
        }

        private void AdminManageItemChangePicButon_Click_1(object sender, EventArgs e) // Change the image in the PictureBox
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Set the selected image to the PictureBox
                        ManageItemPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        isDataChanged = true; // Flag that the image has been changed
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error uploading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminManageItems_Load(object sender, EventArgs e)
        {
            // Any additional setup on form load can go here
        }

        private void AdminManageItemExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageItemDeleteBtn_Click(object sender, EventArgs e)
        {
            // Get the item code from the textbox
            string itemCode = ManageItemItemCodeBox.Text.Trim();

            if (string.IsNullOrEmpty(itemCode))
            {
                MessageBox.Show("Please enter an Item Code to delete.", "No Item Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the item with ItemCode: {itemCode}?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Item WHERE ItemCode = @ItemCode";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ItemCode", itemCode);

                            con.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Reload the DataGridView to reflect the deletion
                            }
                            else
                            {
                                MessageBox.Show("No item found with the specified ItemCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}


