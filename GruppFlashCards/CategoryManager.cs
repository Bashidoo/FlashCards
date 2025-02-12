using GruppFlashCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GruppFlashCards
{
    public partial class CategoryManager : Form
    {
        private string? currentCategory = string.Empty;

        public CategoryManager()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            categoryIdTextBox.Text = string.Empty;
            categoryNameTextBox.Text = string.Empty;
            categoryIdTextBox.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {


            using (var dbContext = new BusherSundayContext())
            {
                try
                {
                    Library library = new Library(dbContext);
                    string categoryName = categoryNameTextBox.Text;
                    int categoryID;
                    if (int.TryParse(categoryIdTextBox.Text, out categoryID))
                    {

                        Category newCategory = new Category(categoryID, categoryName);
                        library.AddCategory(newCategory);
                        outputLabel.Text = $"Category: {categoryName} has been added!";

                    }
                    else
                    {
                        outputLabel.Text = "Please Enter a valid number as CategoryID";
                    }



                }
                catch (Exception ex)
                {
                    outputLabel.Text = $"Error: {ex.Message}";
                }

            }
        }

        private void categoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriesListBox.SelectedItem != null)
            {
                currentCategory = categoriesListBox.SelectedItem.ToString();


            }
        }
        private void LoadCategories()
        {

            categoriesListBox.Items.Clear();


            using (var dbContext = new BusherSundayContext())
            {
                Library library = new Library(dbContext);
                var _categories = dbContext.Categories.ToList();



                if (_categories != null && _categories.Any())
                {
                    foreach (var category in _categories)
                    {
                        categoriesListBox.Items.Add($"{category.CategoryName}");
                    }
                }
                else
                {
                    try
                    {

                        categoriesListBox.Items.Add("nullCategory");
                        if (categoriesListBox == null)
                        {
                            MessageBox.Show("CategoryList is NULL!");
                            return; // Stop execution if it's null
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Category List Error: {ex.Message}");
                    }
                }
            }

            categoriesListBox.SelectedIndexChanged += categoriesListBox_SelectedIndexChanged;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {


            using (var dbContext = new BusherSundayContext())
            {
                Library library = new Library(dbContext);
                Category? categoryExists = dbContext.Categories.FirstOrDefault(x => x.CategoryName == currentCategory);

                try
                {

                    if (categoryExists != null)
                    {
                        int categoryid = categoryExists.CategoryId;
                        library.RemoveCategoryFromList(categoryid);
                        outputLabel.Text = $"Category: {categoryExists.CategoryName} has been removed!";
                    }
                    else
                    {
                        outputLabel.Text = $"Category: is not found in the system!";
                    }
                }
                catch (Exception ex)
                {
                    outputLabel.Text = $"Error: {ex.Message}";
                }
            }
            LoadCategories();
        }
    }
}
