using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Final_Project_for_Studio_2
{
    public partial class WomenCategory : Form
    {
        public WomenCategory()
        {
            InitializeComponent();
        }

        private void WomenCategory_Load(object sender, EventArgs e)
        {
            // Populate the list of categories dynamically
            var categories = new Dictionary<string, string>
            {
                { "Dresses", "Explore our collection of stylish dresses for every occasion." },
                { "Tops", "Discover trendy tops to match your unique style." },
                { "Shoes", "Browse through our elegant and comfortable footwear." },
                { "Accessories", "Find the perfect accessories to complete your outfit." }
            };

            // Bind categories to the ListBox
            foreach (var category in categories.Keys)
            {
                listBoxCategories.Items.Add(category);
            }

            // Store the descriptions in the Tag property for easy access
            listBoxCategories.Tag = categories;
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategories.SelectedItem != null)
            {
                var selectedCategory = listBoxCategories.SelectedItem.ToString();
                var descriptions = (Dictionary<string, string>)listBoxCategories.Tag;
                if (descriptions.ContainsKey(selectedCategory))
                {
                    labelDescription.Text = descriptions[selectedCategory];
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to the main form
            this.Hide();
            var mainForm = new WomenCategory(); // Replace with your main form name
            mainForm.Show();
        }
    }
}
