using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxEmail_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Capture entered data
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            // Validate required fields
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            // Notify the user of a successful registration
            MessageBox.Show("Registration successful! Please Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Redirect to the login form (Form1) after successful registration
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Redirect to login form
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void checkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            
            bool showPassword = checkBoxShowPassword.Checked;
            textBoxPassword.UseSystemPasswordChar = !showPassword;
            textBoxConfirmPassword.UseSystemPasswordChar = !showPassword;
        }
    }
}
