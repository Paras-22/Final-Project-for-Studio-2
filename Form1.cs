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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredEmail = textBoxEmail.Text.Trim();
            string enteredPassword = textBoxPassword.Text;

           
            if (string.IsNullOrWhiteSpace(enteredEmail))
            {
                MessageBox.Show("Please enter an email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            if (registeredUsers.ContainsKey(enteredEmail) && registeredUsers[enteredEmail] == enteredPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

                // Optionally hide the current login form
                this.Hide();
            }
        }
    }
}
