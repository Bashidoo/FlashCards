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
    public partial class FlashCardManager : Form
    {
        private FlashCard newFlashCard = null;
        private string selectedCategory = string.Empty;
        public FlashCardManager()
        {
            InitializeComponent();
            LoadCategories();


        }

        private void categoryManagerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryManagerList_SelectedIndexChanged != null)
            {
                selectedCategory = categoryManagerList.SelectedItem.ToString();
                outputConsoleLabel.Text = $"You have selected {selectedCategory}";
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string flashcardName = flashcardNameTextBox.Text;
            string flashcardQuestion = flashcardQuestionTextBox.Text;
            string flashcardDescription = flashcardDescriptionTextBox.Text;
            string flashcardAnswer = flashcardAnswerTextBox.Text;
            using (var dbContext = new BusherSundayContext())
            {
                Category? categoryName = dbContext.Categories.FirstOrDefault(x => x.CategoryName == selectedCategory);
                int categoryID = categoryName.CategoryId; 
                Library library = new Library(dbContext);
                FlashCard card = new FlashCard(flashcardName, flashcardDescription, flashcardQuestion, flashcardAnswer, categoryID);
                try
                {
                    library.AddFlashCardToList(card);
                    outputConsoleLabel.Text = "Flash Card Added!";
                }
                catch (Exception ex)
                {
                    outputConsoleLabel.Text = $"flash card adding failed: {ex.Message.ToString()}";
                }


            }



        }
        private void LoadCategories()
        {
            using (var dbContext = new BusherSundayContext())
            {
                Library library = new Library(dbContext);
                var _categories = dbContext.Categories.ToList();

                if (_categories != null && _categories.Any())
                {
                    foreach (var category in _categories)
                    {
                        categoryManagerList.Items.Add($"{category.CategoryName}");

                    }


                }
                else
                {
                    try
                    {

                        categoryManagerList.Items.Add("nullCategory");
                        if (categoryManagerList == null)
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

                categoryManagerList.SelectedIndexChanged += categoryManagerList_SelectedIndexChanged;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            flashcardNameTextBox.Text = string.Empty;
            flashcardDescriptionTextBox.Text = string.Empty;
            flashcardAnswerTextBox.Text = string.Empty;
            flashcardQuestionTextBox.Text = string.Empty;
            flashcardNameTextBox.Focus();

        }
    }
}
