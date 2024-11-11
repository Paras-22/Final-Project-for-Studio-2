using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form5 : Form
    {
        // Declare a timer for countdown functionality
        private Timer countdownTimer;
        private int countdownTime = 60; // 60 seconds countdown

        // Constructor for Form5
        public Form5()
        {
            InitializeComponent();
            InitializeCountdownTimer();
        }

        // Initialize countdown timer
        private void InitializeCountdownTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second interval
            countdownTimer.Tick += CountdownTimer_Tick;
            lblCountdown.Text = $"Time Left: {countdownTime} seconds";
        }

        // Countdown timer tick event
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            lblCountdown.Text = $"Time Left: {countdownTime} seconds";

            if (countdownTime <= 0)
            {
                countdownTimer.Stop();
                MessageBox.Show("Checkout time has expired. Please try again.");
            }
        }

        // Button click event for Continue Shopping
        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continuing shopping...");
        }

        // Button click event for Clear Trolley
        private void btnClearTrolley_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trolley cleared.");
            // Clear the trolley and reset the subtotal and estimated total values
            lblTrolleyStatus.Text = "Trolley: No items";
            lblSubtotal.Text = "Subtotal: $0.00";
            lblEstimatedTotal.Text = "Estimated Total: $0.00";
        }

        // Button click event for Checkout
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            MessageBox.Show("Proceeding to checkout...");
            // Add any additional checkout logic here if necessary
        }

        // Form load event to start countdown timer
        private void Form5_Load(object sender, EventArgs e)
        {
            countdownTimer.Start();
        }

        private void pnlActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlTrolleyInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}