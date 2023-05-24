using ParootsManagement.Models;
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
    public partial class AddBirdForm : Form
    {
        private Database database;

        public AddBirdForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        //private void btnAddBird_Click(object sender, EventArgs e)
        //{
        //    // Retrieve the bird details from the form controls
        //    int id = Convert.ToInt32(txtId.Text);
        //    string species = cmbSpecies.Text;
        //    string subSpecies = cmbSubSpecies.Text;
        //    DateTime birthDate = dtpBirthDate.Value;
        //    string gender = cmbGender.Text;
        //    string cageNumber = txtCageNumber.Text;
        //    int fatherId = Convert.ToInt32(txtFatherId.Text);
        //    int motherId = Convert.ToInt32(txtMotherId.Text);

        //    // Validate the bird details
        //    if (!ValidateBirdDetails(id, species, subSpecies, birthDate, gender, cageNumber, fatherId, motherId))
        //    {
        //        MessageBox.Show("Invalid bird details. Please check the inputs.");
        //        return;
        //    }

        //    // Create a new Bird object
        //    Bird newBird = new Bird
        //    {
        //        Id = id,
        //        Specie = species,
        //        SubSpecie = subSpecies,
        //        BirthDate = birthDate,
        //        Gender = gender,
        //        CageNumber = cageNumber,
        //        FatherIdentificationNumber = fatherId,
        //        MotherIdentificationNumber = motherId,
        //        UserId = currentUser.Id // Assuming a currentUser variable is available to get the current user ID
        //    };

        //    // Add the new bird to the database
        //    database.Birds.Add(newBird);
        //    SaveDatabase();

        //    MessageBox.Show("Bird added successfully!");
        //    ClearForm();
        //}

        //private bool ValidateBirdDetails(int id, string species, string subSpecies, DateTime birthDate, string gender, string cageNumber, int fatherId, int motherId)
        //{
        //    // Perform the necessary validation logic based on the provided rules
        //    // Return true if the bird details are valid, false otherwise
        //    // You can validate the details against the specified rules (e.g., ID format, species and sub-species options, birth date range, etc.)
        //    // You may also perform additional checks as needed

        //    // Example validation (replace with your own rules):
        //    if (id <= 0)
        //        return false;

        //    if (string.IsNullOrEmpty(species))
        //        return false;

        //    if (string.IsNullOrEmpty(subSpecies))
        //        return false;

        //    // Perform other validations as per your requirements

        //    return true;
        //}

        //private void SaveDatabase()
        //{
        //    // Save the updated database using the appropriate mechanism (e.g., JSON serialization, Excel writing)
        //    // This code will depend on how you have implemented the database and the save mechanism
        //    // Make sure to update the database with the current user's data
        //}

        //private void ClearForm()
        //{
        //    // Clear the form controls to prepare for adding a new bird
        //    txtId.Text = string.Empty;
        //    cmbSpecies.SelectedIndex = -1;
        //    cmbSubSpecies.SelectedIndex = -1;
        //    dtpBirthDate.Value = DateTime.Now;
        //    cmbGender.SelectedIndex = -1;
        //    txtCageNumber.Text = string.Empty;
        //    txtFatherId.Text = string.Empty;
        //    txtMotherId.Text = string.Empty;
        //}
    }
}
