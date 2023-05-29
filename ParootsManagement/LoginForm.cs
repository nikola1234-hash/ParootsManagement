using OfficeOpenXml;
using ParootsManagement.Const;
using ParootsManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParootsManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            // Perform login logic
            if (ValidateLogin(username, password))
            {
                // Successful login
                MessageBox.Show("Login successful!");
                CreateUserPersistance(username, password);
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                // Invalid login credentials
                MessageBox.Show("Invalid username or password!");
            }
        }
        private void CreateUserPersistance(string username, string password)
        {
            var excelData = ExcelService.ReadExcelData();
            var user = excelData.Where(s => s["username"].ToString() == username && s["password"].ToString() == password).FirstOrDefault();
            if (user != null)
            {
                Guid.TryParse(user["id"].ToString(), out Guid id);
                UserStore.Id = id;
                UserStore.Username = user["username"].ToString();
            }

        }
        private bool ValidateLogin(string username, string password)
        {
            var excelData = ExcelService.ReadExcelData();

            // Perform validation logic based on the retrieved data
            bool validCredentials = excelData.Any(row =>
            {
                return row.ContainsKey("username") && row["username"].ToString() == username &&
                       row.ContainsKey("password") && row["password"].ToString() == password;
            });

            return validCredentials;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
