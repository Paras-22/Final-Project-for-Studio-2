﻿using System;
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

            // Add cart items to the ListBox
            foreach (var item in cartItems)
            {
                listBoxItems.Items.Add(item);
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = placeholderText;
                textBox2.ForeColor = Color.Gray; // Change text color to indicate placeholder
            }
        }

        // GotFocus event handler for textBox2
        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (textBox2.Text == placeholderText)
            {
                textBox2.Text = string.Empty; // Clear placeholder
                textBox2.ForeColor = Color.Black; // Change text color to default
            }
        }

        // LostFocus event handler for textBox2
        private void textBox2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SetPlaceholder(); // Restore placeholder if the field is empty
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size = new Size(780, 625);
            SetPlaceholder();
            SetCvcPlaceholder();
            SetCardPlaceholder();

        }

        private void SetCardPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = cardPlaceholderText;
                textBox3.ForeColor = Color.Gray; // Change text color to indicate placeholder
            }
        }

        // GotFocus event handler for textBox3
        private void textBox3_GotFocus(object sender, EventArgs e)
        {
            if (textBox3.Text == cardPlaceholderText)
            {
                textBox3.Text = string.Empty; // Clear placeholder
                textBox3.ForeColor = Color.Black; // Change text color to default
            }
        }

        // LostFocus event handler for textBox3
        private void textBox3_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SetCardPlaceholder(); // Restore placeholder if the field is empty
            }
        }

        private void SetCvcPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = cvcPlaceholderText;
                textBox6.ForeColor = Color.Gray; // Change text color to indicate placeholder
            }
        }

        // GotFocus event handler for textBox6
        private void textBox6_GotFocus(object sender, EventArgs e)
        {
            if (textBox6.Text == cvcPlaceholderText)
            {
                textBox6.Text = string.Empty; // Clear placeholder
                textBox6.ForeColor = Color.Black; // Change text color to default
            }
        }

        // LostFocus event handler for textBox6
        private void textBox6_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                SetCvcPlaceholder(); // Restore placeholder if the field is empty
            }
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

            // Assuming the TextBox for home address is named "buttonPay"

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Please enter a valid home address. Avoid using special characters or leaving it empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return;
            }

            // Method to validate home address
           
            

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

        

        // Validate Card Number (16 digits)
        private bool IsCardNumberValid(string cardNumber)
        {
            return cardNumber.Length == 16 && long.TryParse(cardNumber, out _);
        }

        // Validate Expiry Date (MM/YY format)
        private bool IsExpiryDateValid(string expiryDate)
        {
            if (!expiryDate.Contains("/")) return false;

            string[] parts = expiryDate.Split('/');
            if (parts.Length != 2) return false;

            if (!int.TryParse(parts[0], out int month) || month < 1 || month > 12) return false;
            if (!int.TryParse(parts[1], out int year) || year < DateTime.Now.Year % 100) return false;

            return true;
        }

        // Validate CVC (3 digits)
        private bool IsCvcValid(string cvc)
        {
            return cvc.Length == 3 && int.TryParse(cvc, out _);
        }

        private void UpdateTotals_Click(object sender, EventArgs e)
        {
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            var result = MessageBox.Show("Are you sure you want to cancel the payment and return to the dashboard?",
                                         "Cancel Payment",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the user clicks "Yes"
            if (result == DialogResult.Yes)
            {
                // Open the Dashboard form
                Dashboard1 dashboard = new Dashboard1();
                dashboard.Show();

                // Close the current form (optional)
                this.Close();
            }
        }

    }
}


    

