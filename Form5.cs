using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form5 : Form
    {
        private Timer countdownTimer;
        private int countdownTime = 60; // Countdown in seconds
        private decimal subtotal = 0.00m;
        private decimal deliveryFee = 5.00m; // Set delivery fee
        private decimal estimatedTotal = 0.00m;

        public Form5()
        {
            InitializeComponent();
            InitializeCountdownTimer();
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
            subtotal = CalculateSubtotal();
            estimatedTotal = subtotal + deliveryFee;
            lblSubtotal.Text = $"Subtotal: ${subtotal:F2}";
            lblDeliveryFee.Text = $"Delivery Fee: ${deliveryFee:F2}";
            lblEstimatedTotal.Text = $"Estimated Total: ${estimatedTotal:F2}";
        }

        private decimal CalculateSubtotal()
        {
            // Add logic for calculating subtotal here
            return 0.00m; // Placeholder
        }

        private void ResetTrolley()
        {
            lblTrolleyStatus.Text = "Trolley: No items";
            lstItems.Items.Clear();
            subtotal = 0.00m;
            UpdateTotal();
            countdownTime = 60;
            lblCountdown.Text = $"Time Left: {countdownTime} seconds";
            countdownTimer.Start();
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continuing shopping...");
            // Logic to continue shopping (e.g., navigate to another form or update trolley items)
        }

        private void btnClearTrolley_Click(object sender, EventArgs e)
        {
            ResetTrolley();
            MessageBox.Show("Trolley cleared.");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            MessageBox.Show("Proceeding to checkout...");
            // Add additional checkout logic here, such as navigating to a payment form
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }
    }
}