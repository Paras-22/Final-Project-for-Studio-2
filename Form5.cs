using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form5 : Form
    {
        private Timer countdownTimer;
        private int countdownTime = 60;
        private decimal subtotal = 0.00m;
        private decimal deliveryFee = 5.00m;
        private decimal estimatedTotal = 0.00m;

        public Form5()
        {
            InitializeComponent();
            InitializeCountdownTimer();
            UpdateTotal();
        }

        public void AddToCart(string productName, int quantity, decimal price)
        {
            if (lstItems.Items.Count == 0)
            {
                lstItems.Items.Add("Your Order:");
                lstItems.Items.Add("============");
                lstItems.Items.Add("");
            }  

            string cartItem = $"{quantity} x {productName} @ ${price:F2} each";
            lstItems.Items.Add(cartItem);

            subtotal += price * quantity;
            UpdateTotal();
        }


        private void InitializeCountdownTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            lblCountdown.Text = $"Time Left: {countdownTime} seconds";
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            lblCountdown.Text = $"Time Left: {countdownTime} seconds";

            if (countdownTime <= 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Checkout time has expired. Please try again.");
                ResetTrolley();
            }
        }

        private void UpdateTotal()
        {
            estimatedTotal = subtotal + deliveryFee;
            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDeliveryFee.Text = $"Delivery Fee: ${deliveryFee:F2}";
            lblEstimatedTotal.Text = $"Estimated Total: ${estimatedTotal:F2}";
        }

        private void ResetTrolley()
        {
            lstItems.Items.Clear();
            subtotal = 0.00m;
            UpdateTotal();
            countdownTime = 60;
            lblCountdown.Text = $"Time Left: {countdownTime} seconds";
            countdownTimer.Start();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Application.OpenForms["Dashboard1"].Show();
        }

        private void btnClearTrolley_Click(object sender, EventArgs e)
        {
            ResetTrolley();
            MessageBox.Show("Trolley cleared.");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Stop the countdown timer
            countdownTimer.Stop();

            // Collect items from the ListBox
            List<string> cartItems = new List<string>();
            foreach (var item in lstItems.Items)
            {
                cartItems.Add(item.ToString());
            }

            // Pass the items and the estimated total to Form4 (payment page)
            Form4 paymentPage = new Form4(cartItems, estimatedTotal);
            paymentPage.Show(); // Open the payment page
            this.Close(); // Close the checkout page
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }
        private void tblLayoutPrices_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
