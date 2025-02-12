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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            using (var dbContext = new BusherSundayContext())
            {
                Library library = new Library(dbContext);
                string userName = userNameTextBox.Text;
                string userEmail = userEmailTextBox.Text;
                string userPassword = userPasswordTextBox.Text;
                try
                {
                    User newUser = new User(userName, userEmail, userPassword);
                    library.AddUserToList(newUser);
                    outputLabel.Text = $"User: {newUser.UserName} has been successfully registered!";
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    outputLabel.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Text = string.Empty;
            userEmailTextBox.Text = string.Empty;
            userPasswordTextBox.Text = string.Empty;
            userNameTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
