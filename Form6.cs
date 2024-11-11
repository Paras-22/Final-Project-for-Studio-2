using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form6 : Form
    {
        private int _userId;

        public Form6(int userId)
        {
            InitializeComponent();
            _userId = userId; // User ID passed from Form5
            InitializeDataGridView();
            LoadPastOrders();
        }

        // Method to initialize DataGridView settings
        private void InitializeDataGridView()
        {
            dgvPastOrders.AutoGenerateColumns = true;
            dgvPastOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPastOrders.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPastOrders.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPastOrders.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dgvPastOrders.ReadOnly = true;
            dgvPastOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPastOrders.MultiSelect = false;
        }

        // Method to load past orders into DataGridView
        private void LoadPastOrders()
        {
            string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=YOUR_DATABASE_NAME;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Query to fetch past orders for the current user
                    string query = @"
                        SELECT 
                            OrderID AS 'Order ID',
                            ProductName AS 'Product Name',
                            Quantity AS 'Quantity',
                            TotalPrice AS 'Total Price',
                            OrderDate AS 'Order Date'
                        FROM Orders
                        WHERE UserID = @UserID
                        ORDER BY OrderDate DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@UserID", _userId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if data exists
                    if (dt.Rows.Count > 0)
                    {
                        dgvPastOrders.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No past orders found for this user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading past orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Back button click event to return to Form5
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
