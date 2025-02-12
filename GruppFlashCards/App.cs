using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GruppFlashCards.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace GruppFlashCards
{
    public partial class App : Form
    {
        private string formatedDate = DateTime.Now.ToString("yyyy-MM-dd");
        private FlashCard currentFlashcard = null;
        private string currentAnswer = string.Empty;
        private string currentCategory = string.Empty;
        private User? _loggedInUser;
        public App(User? user)
        {
            InitializeComponent();
            _loggedInUser = user;
            userOBJLabel.Text = $"Welcome, {user?.UserName}";
            LoadCategories();



        }

        private void Logout_Click_Click(object sender, EventArgs e)
        {
            ApplicationUI loginForm = new ApplicationUI();
            this.Hide();
            _loggedInUser = null;
            loginForm.Show();

        }

        private void LoadCategories()
        {

            categoryList.Items.Clear();


            using (var dbContext = new BusherSundayContext())
            {
                Library library = new Library(dbContext);
                var _categories = dbContext.Categories.ToList();



                if (_categories != null && _categories.Any())
                {
                    foreach (var category in _categories)
                    {
                        categoryList.Items.Add($"{category.CategoryName}");
                    }
                }
                else
                {
                    try
                    {

                        categoryList.Items.Add("nullCategory");
                        if (CategoryList == null)
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

            categoryList.SelectedIndexChanged += CategoryList_SelectedIndexChanged;
        }

        private void LoadQuestionByCategory(string categoryName)
        {
            using (var dbContext = new BusherSundayContext())
            {
                var category = dbContext.Categories.Include(a => a.FlashCards)
                .FirstOrDefault(a => a.CategoryName == categoryName);
                currentCategory = categoryName;


                if (category != null && category.FlashCards.Any())
                {
                    var dueFlashcard = category.FlashCards
                   .Where(f => f.FlashCardInterval <= DateTime.Now)
                   .OrderBy(f => f.FlashCardInterval)
                   .FirstOrDefault();

                    if (dueFlashcard != null)
                    {
                        questionPrompt.Text = dueFlashcard.FlashCardQuestion;
                        currentAnswer = dueFlashcard.FlashCardAnswer;
                        currentFlashcard = dueFlashcard;

                    }

                }
                else
                {
                    questionPrompt.Text = "No questions available for this category";
                    currentAnswer = string.Empty;
                }
            }
        }

        private void LoadNextFlashCard()
        {
            if (!string.IsNullOrEmpty(currentCategory))
            {
                LoadQuestionByCategory(currentCategory);
            }
        }



        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryList.SelectedItem != null)
            {
                string? categoryName = categoryList.SelectedItem.ToString();
                LoadQuestionByCategory(categoryName);
            }

        }


        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void flashcardManager_Click(object sender, EventArgs e)
        {
            // Add logic
            FlashCardManager flashcardManagerForm = new FlashCardManager();
            flashcardManagerForm.Show();
        }

        private void categoryManagerButton_Click(object sender, EventArgs e)
        {
            CategoryManager categoryManagerForm = new CategoryManager();
            categoryManagerForm.Show();
            
            
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void questionPrompt_Click(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string userAnswer = answerTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(userAnswer) && currentFlashcard != null)
            {

                bool isCorrect = string.Equals(userAnswer, currentAnswer, StringComparison.OrdinalIgnoreCase);
                if (isCorrect)
                {
                    outputLabel.Text = $"Correct!";

                using (var dbContext = new BusherSundayContext())
                {
                    Library library = new Library(dbContext);
                    library.UpdateSpacedRepitition(currentFlashcard, isCorrect == true);
                }

                    outputDateLabel.Text = $"Next Review Date: {currentFlashcard.FlashCardInterval.ToString("dd/MM/yyyy")}";
                    LoadNextFlashCard();
                }
                else
                {
                    outputLabel.Text = $"False! The correct answer is: {currentAnswer}";
                    outputDateLabel.Text = $"Next Review Date: {currentFlashcard.FlashCardInterval.ToString("dd/MM/yyyy")}";
                }
            }
            else
            {
                outputLabel.Text = $"No question loaded!";
            }


            currentAnswer = string.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerTextBox.Text = string.Empty;
            outputDateLabel.Text = string.Empty;
            answerTextBox.Focus();
        }
    }
}
