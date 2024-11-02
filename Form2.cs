using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // This event can be used for form load initializations, if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if necessary
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            // Handle email text changed event, if needed
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
            textBoxConfirmPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validation logic for registration
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Registration successful
            MessageBox.Show("Registration Successful! Welcome.");
            // Additional registration logic can be added here
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}