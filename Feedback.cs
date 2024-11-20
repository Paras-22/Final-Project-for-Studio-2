using System;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string rating = cmbRating.SelectedItem?.ToString();
            string comments = txtComments.Text;

            // Simple validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(rating))
            {
                MessageBox.Show("Please fill in all fields before submitting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Here you could send feedback to a server or store it in a database
                MessageBox.Show($"Thank you, {name}, for your feedback!\nRating: {rating}\nComments: {comments}",
                                 "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after submission
                txtName.Clear();
                txtEmail.Clear();
                cmbRating.SelectedIndex = -1;
                txtComments.Clear();
            }
        }

        private void lblSubHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
