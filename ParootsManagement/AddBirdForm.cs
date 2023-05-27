using ParootsManagement.Const;
using ParootsManagement.Models;
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
    public partial class AddBirdForm : Form
    {
        private Database database;
        private DatabaseService databaseService;
        private Bird bird;
        enum Gender
        {
            Male,
            Female
        }

        public AddBirdForm(Database db)
        {
            InitializeComponent();
            database = db;
            databaseService = new DatabaseService();
            PopulateComboBoxes();
        }
        public AddBirdForm(Bird bird, Database db)
        {
            InitializeComponent();
            database = db;
            this.bird = bird;
            databaseService = new DatabaseService();
            PopulateComboBoxes();
            InitializeFields();

        }
        private void InitializeFields()
        {
            if (bird is null)
            {
                MessageBox.Show("Fatal error");
                return;
            }


            specieComboBox.SelectedItem = bird.Specie;
            genderComboBox.SelectedItem = bird.Gender;
            birthDatePicker.Value = bird.BirthDate;
            cageNumberTextBox.Text = bird.CageNumber;
            fatherId.Text = bird.FatherIdentificationNumber.ToString();
            motherId.Text = bird.MotherIdentificationNumber.ToString();
            button1.Text = "Update";
            button1.Click -= btnAddBird_Click;
            button1.Click += update_Click;

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the bird details from the form controls
                string species = specieComboBox.Text;
                string subSpecies = subSpecieComboBox.Text;
                DateTime birthDate = birthDatePicker.Value;
                string gender = genderComboBox.Text;
                string cageNumber = cageNumberTextBox.Text;
                int fatherIdNumber;
                int motherIdNumber;


                // Parse fatherId and motherId using Int32.TryParse()
                if (!int.TryParse(fatherId.Text, out fatherIdNumber))
                {
                    MessageBox.Show("Father ID must be a valid number.");
                    return;
                }

                if (!int.TryParse(motherId.Text, out motherIdNumber))
                {
                    MessageBox.Show("Mother ID must be a valid number.");
                    return;
                }
                // Validate the bird details
                if (!ValidateBirdDetails(species, subSpecies, birthDate, gender, cageNumber, fatherIdNumber, motherIdNumber))
                {
                    MessageBox.Show("Invalid bird details. Please check the inputs.");
                    return;
                }

                var birdToUpdate = database.Birds.FirstOrDefault(s => s.Id == bird.Id);
                var index = database.Birds.IndexOf(birdToUpdate);
                if (birdToUpdate == null)
                {
                    MessageBox.Show("This bird doesnt exist with this ID");
                    return;
                }
                birdToUpdate.Specie = species;
                birdToUpdate.SubSpecie = subSpecies;
                birdToUpdate.BirthDate = birthDate;
                birdToUpdate.Gender = gender;
                birdToUpdate.CageNumber = cageNumber;
                birdToUpdate.FatherIdentificationNumber = fatherIdNumber;
                birdToUpdate.MotherIdentificationNumber = motherIdNumber;
                // Add the new bird to the database
                database.Birds[index] = birdToUpdate;
                SaveDatabase();

                MessageBox.Show("Bird updated successfully!");
                ClearForm();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                this.DialogResult = DialogResult.Abort;
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PopulateComboBoxes()
        {
            // Populate the specie ComboBox
            specieComboBox.Items.AddRange(Enum.GetNames(typeof(Specie)));
            genderComboBox.Items.AddRange(Enum.GetNames(typeof(Gender)));
        }

        private void SpecieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the sub-specie ComboBox
            subSpecieComboBox.SelectedIndex = -1;
            subSpecieComboBox.Items.Clear();
            subSpecieComboBox.Refresh();

            // Get the selected specie
            if (specieComboBox.SelectedItem is string selectedSpecie)
            {
                // Determine the corresponding sub-specie options
                switch ((Specie)Enum.Parse(typeof(Specie), selectedSpecie))
                {
                    case Specie.AmericanGoldian:
                        {
                            string[] subSpecieOptions = Enum.GetNames(typeof(SubSpecie));
                            string[] americanGoldianOptions = new string[] {
                                subSpecieOptions[(int)SubSpecie.NorthAmerica],
                                subSpecieOptions[(int)SubSpecie.SouthAmerica],
                                subSpecieOptions[(int)SubSpecie.CentralAmerica]
                            };
                            subSpecieComboBox.Items.AddRange(americanGoldianOptions);
                            break;
                        }
                    case Specie.EuropeanGoldian:
                        {
                            string[] subSpecieOptions = Enum.GetNames(typeof(SubSpecie));
                            string[] europeanGoldianOptions = new string[] {
                                subSpecieOptions[(int)SubSpecie.EastEurope],
                                subSpecieOptions[(int)SubSpecie.WestEurope]
                            };
                            subSpecieComboBox.Items.AddRange(europeanGoldianOptions);
                            break;
                        }
                    case Specie.AustralianGoldian:
                        {
                            string[] subSpecieOptions = Enum.GetNames(typeof(SubSpecie));
                            string[] australianGoldianOptions = new string[] {
                                subSpecieOptions[(int)SubSpecie.CentralAustralia],
                                subSpecieOptions[(int)SubSpecie.BeachCities]
                            };
                            subSpecieComboBox.Items.AddRange(australianGoldianOptions);
                            break;
                        }
                }
            }
        }

        private void btnAddBird_Click(object sender, EventArgs e)
        {
            // Retrieve the bird details from the form controls
            string species = specieComboBox.Text;
            string subSpecies = subSpecieComboBox.Text;
            DateTime birthDate = birthDatePicker.Value;
            string gender = genderComboBox.Text;
            string cageNumber = cageNumberTextBox.Text;
            int fatherIdNumber;
            int motherIdNumber;


            // Parse fatherId and motherId using Int32.TryParse()
            if (!int.TryParse(fatherId.Text, out fatherIdNumber))
            {
                MessageBox.Show("Father ID must be a valid number.");
                return;
            }

            if (!int.TryParse(motherId.Text, out motherIdNumber))
            {
                MessageBox.Show("Mother ID must be a valid number.");
                return;
            }
            // Validate the bird details
            if (!ValidateBirdDetails(species, subSpecies, birthDate, gender, cageNumber, fatherIdNumber, motherIdNumber))
            {
                MessageBox.Show("Invalid bird details. Please check the inputs.");
                return;
            }


            Bird newBird = new Bird
            {
                Id = GetNextBirdId(),
                Specie = species,
                SubSpecie = subSpecies,
                BirthDate = birthDate,
                Gender = gender,
                CageNumber = cageNumber,
                FatherIdentificationNumber = fatherIdNumber,
                MotherIdentificationNumber = motherIdNumber,
                UserId = UserStore.Id
            };

            // Add the new bird to the database
            database.Birds.Add(newBird);
            SaveDatabase();

            MessageBox.Show("Bird added successfully!");
            ClearForm();
        }
        private bool ValidateBirdDetails(string species, string subSpecies, DateTime birthDate, string gender, string cageNumber, int fatherId, int motherId)
        {
            if (string.IsNullOrEmpty(species))
            {
                MessageBox.Show("Please select a species.");
                return false;
            }

            if (string.IsNullOrEmpty(subSpecies))
            {
                MessageBox.Show("Please select a sub-species.");
                return false;
            }

            if (birthDate > DateTime.Now)
            {
                MessageBox.Show("Birth date cannot be in the future.");
                return false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }

            if (string.IsNullOrEmpty(cageNumber))
            {
                MessageBox.Show("Please enter a cage number.");
                return false;
            }

            if (fatherId <= 0)
            {
                MessageBox.Show("Father ID must be a positive number.");
                return false;
            }

            if (motherId <= 0)
            {
                MessageBox.Show("Mother ID must be a positive number.");
                return false;
            }

            // Additional custom validations can be added here

            return true;
        }

        private void SaveDatabase()
        {
            databaseService.WriteData(database);
        }

        private void ClearForm()
        {
            // Clear the form controls to prepare for adding a new bird
            specieComboBox.SelectedIndex = -1;
            subSpecieComboBox.SelectedIndex = -1;
            birthDatePicker.Value = DateTime.Now;
            genderComboBox.SelectedIndex = -1;
            cageNumberTextBox.Text = string.Empty;
            fatherId.Text = string.Empty;
            motherId.Text = string.Empty;
        }

        private int GetNextBirdId()
        {
            int maxId = 0;
            try
            {
                maxId = database.Birds.Max(bird => bird.Id);
            }
            catch (Exception ex)
            {

                //Ignore
            }
            return maxId + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
