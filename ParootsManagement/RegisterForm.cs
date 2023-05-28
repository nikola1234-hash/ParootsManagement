using ParootsManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParootsManagement
{
    public partial class RegisterForm : Form
    {

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            var confirmPassword = textBox3.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            var excelData = ExcelService.ReadExcelData();

            if (ValidateRegistration(username, password, excelData))
            {
                // Successful registration
                MessageBox.Show("Registration successful!");

                // Create a new dictionary to hold the user details
                var userId = Guid.NewGuid();

                // Create a new dictionary to hold the user details
                var newUser = new Dictionary<string, object>
                {
                    { "userId", userId },
                    { "username", username },
                    { "password", password }
                };

                excelData.Add(newUser); // Add the new user details to the existing data

                ExcelService.WriteExcelData(excelData);

                this.Close();

            }
        }

        private bool ValidateRegistration(string username, string password, List<Dictionary<string, object>> excelData)
        {
            // Validate the username
            if (!Regex.IsMatch(username, "^(?=(.*\\d){2})(?=.*[a-zA-Z])[a-zA-Z\\d]{6,8}$"))
            {
                MessageBox.Show("Invalid username! Username should contain 6-8 characters with a maximum of 2 digits.");
                return false;
            }

            // Validate the password
            if (!Regex.IsMatch(password, "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@#$!])[A-Za-z\\d@#$!]{8,10}$"))
            {
                MessageBox.Show("Invalid password! Password should contain 8-10 characters with at least one letter, one digit, and one special symbol.");
                return false;
            }


            var usernameExists = excelData.Any(row => row["username"].ToString() == username);

            if (usernameExists)
            {
                MessageBox.Show("Username already exists! Please choose a different username.");
                return false;
            }

            // If all validations pass, return true
            return true;
        }
    }
}
