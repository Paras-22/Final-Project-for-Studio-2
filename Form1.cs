using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// ==================================
// This form is for Paras for Login.
// ==================================
//

namespace Final_Project_for_Studio_2
{
    public partial class Form1 : Form
    {

        // I have created Dictionary to store registered users with email as key and password as value
        // Used them as a mock database

        private Dictionary<string, string> registeredUsers = new Dictionary<string, string>
        {
            { "tom@123.com", "123" },
            { "Paras@gmail.com", "123" }
        };

       
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // This is the event handler for login button click event.
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Capture the entered email and password
            string enteredEmail = textBoxEmail.Text.Trim();
            string enteredPassword = textBoxPassword.Text;

            // Check if email is empty and prompt the user if it is
            if (string.IsNullOrWhiteSpace(enteredEmail))
            {
                MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if email is empty
            }

            // Check if password is empty and prompt the user if it is
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if password is empty
            }

            // Check if the entered email and password match any registered user in the dictionary
            if (registeredUsers.ContainsKey(enteredEmail) && registeredUsers[enteredEmail] == enteredPassword)
            {
                // Show success message if login is successful
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                // Show error message if email or password is incorrect
                MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the email and password text boxes
                textBoxEmail.Text = string.Empty;
                textBoxPassword.Text = string.Empty;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void labelLogin_Click(object sender, EventArgs e)
        {
            
        }

        
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
