using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form4 : Form
    {
        private decimal totalAmount;
        private string placeholderText = "MM/YY";
        private string cvcPlaceholderText = "Ex - 232";
        private string cardPlaceholderText = "Enter 16-digit card number";

        public Form4(List<string> cartItems, decimal totalAmount)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;

            // Display the total amount
            UpdateTotals.Text = $"${totalAmount:F2}";



           
            listBoxItems.Items.Add("");// Adds a separator line for clarity

            // Add cart items to the ListBox
            foreach (var item in cartItems)
            {
                listBoxItems.Items.Add(item);
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeholder)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void ClearPlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size = new Size(850, 650);

            // Initialize placeholders
            SetPlaceholder(textBox2, placeholderText);
            SetPlaceholder(textBox3, cardPlaceholderText);
            SetPlaceholder(textBox6, cvcPlaceholderText);

            // Attach event handlers
            textBox2.GotFocus += (s, ev) => ClearPlaceholder(textBox2, placeholderText);
            textBox2.LostFocus += (s, ev) => SetPlaceholder(textBox2, placeholderText);

            textBox3.GotFocus += (s, ev) => ClearPlaceholder(textBox3, cardPlaceholderText);
            textBox3.LostFocus += (s, ev) => SetPlaceholder(textBox3, cardPlaceholderText);

            textBox6.GotFocus += (s, ev) => ClearPlaceholder(textBox6, cvcPlaceholderText);
            textBox6.LostFocus += (s, ev) => SetPlaceholder(textBox6, cvcPlaceholderText);
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            // Validate Cardholder's Name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter the cardholder's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Validate Card Number
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !IsCardNumberValid(textBox3.Text))
            {
                MessageBox.Show("Please enter a valid card number. It must contain 16 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }

            // Validate Expiry Date
            if (string.IsNullOrWhiteSpace(textBox2.Text) || !IsExpiryDateValid(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid expiry date in MM/YY format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            // Validate CVC
            if (string.IsNullOrWhiteSpace(textBox6.Text) || !IsCvcValid(textBox6.Text))
            {
                MessageBox.Show("Please enter a valid CVC. It must be a 3-digit number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
                return;
            }

            // If all fields are valid, proceed with payment
            MessageBox.Show(
                $"Payment of {UpdateTotals.Text} successful!",
                "Payment Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Dashboard1 dashboard = new Dashboard1();
            dashboard.Show();
            this.Close();
        }

        private bool IsCardNumberValid(string cardNumber)
        {
            return cardNumber.Length == 16 && long.TryParse(cardNumber, out _);
        }

        private bool IsExpiryDateValid(string expiryDate)
        {
            if (!expiryDate.Contains("/")) return false;

            string[] parts = expiryDate.Split('/');
            if (parts.Length != 2) return false;

            if (!int.TryParse(parts[0], out int month) || month < 1 || month > 12) return false;
            if (!int.TryParse(parts[1], out int year) || year < DateTime.Now.Year % 100) return false;

            return true;
        }

        private bool IsCvcValid(string cvc)
        {
            return cvc.Length == 3 && int.TryParse(cvc, out _);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel the payment and return to the dashboard?",
                                         "Cancel Payment",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Dashboard1 dashboard = new Dashboard1();
                dashboard.Show();
                this.Close();
            }
        }

        private void UpdateTotals_Click(object sender, EventArgs e)
        {
        }
    }
}
