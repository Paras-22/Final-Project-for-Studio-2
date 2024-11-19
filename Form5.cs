using System;
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
            // Add the item to the listbox
            string cartItem = $"{quantity} x {productName} @ ${price:F2} each";
            lstItems.Items.Add(cartItem);

            // Update subtotal
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
