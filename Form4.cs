using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form4 : Form
    {
        // Constructor to accept cart items from Form5
        public Form4(List<string> cartItems)
        {
            InitializeComponent();
            

            // Add cart items to the ListBox (e.g., listBoxPaymentPage)
            foreach (var item in cartItems)
            {
                listBoxItems.Items.Add(item); // Ensure listBoxPaymentPage exists on Form4
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Any additional initialization logic for Form4
        }

        private void UpdateTotals_Click(object sender, EventArgs e)
        {

        }
    }
}
