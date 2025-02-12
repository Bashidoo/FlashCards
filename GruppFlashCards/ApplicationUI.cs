using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using GruppFlashCards.Models;

namespace GruppFlashCards
{
    public partial class ApplicationUI : Form
    {
        public ApplicationUI()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=LAPTOP-6O16HQII\SQLEXPRESS;Database=busherSunday;Trusted_Connection=True;TrustServerCertificate=True;");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string email, password;

            email = txt_Email.Text;
            password = txt_password.Text;
            try
            {
                conn.Open();
               // string loginquery = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";

                using (var dbContext = new BusherSundayContext())
                {
                    Library library = new Library(dbContext);
                    User? loginResult = library.UserLogin(email, password);

                   
                    if (loginResult != null)
                    {
                        MessageBox.Show("Login successful!");
                        
                        App appForm = new App(loginResult);
                        appForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Email.Clear();
                        txt_password.Clear();
                        txt_Email.Focus();// to focus email. forces user point to click on email text box.
                    }

                }
            }


            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_Email.Clear();
            txt_password.Clear();

            txt_Email.Focus();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();

            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}
