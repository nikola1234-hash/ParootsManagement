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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParootsManagement
{
    public partial class CageForm : Form
    {
        private Database database;
        private DatabaseService databaseService => new DatabaseService();
        Cage cage = new Cage();
        public CageForm(Database database)
        {
            InitializeComponent();
            this.database = database;

            InitializeDatabase();
            InitializeComboBox();


        }
        public CageForm(Cage cage, Database database)
        {
            InitializeComponent();
            this.database = database;
            this.cage = cage;
            InitializeDatabase();
            InitializeComboBox();


        }
        private void InitializeDatabase()
        {
            database = databaseService.ReadData<Database>();
            if (database == null)
            {
                database = new Database();
            }
        }


        private void InitializeComboBox()
        {
            MaterialComboBox.DataSource = Enum.GetValues(typeof(Material));
        }
        private void AddCageButton_Click(object sender, EventArgs e)
        {
            // Get the user-entered values from the form controls
            double height = Convert.ToDouble(HeightTextBox.Text);
            double width = Convert.ToDouble(WidthTextBox.Text);
            double length = Convert.ToDouble(LengthTextBox.Text);
            Material material = (Material)MaterialComboBox.SelectedItem;

            if (!ValidateDimension(HeightTextBox.Text) || !ValidateDimension(WidthTextBox.Text) || !ValidateDimension(LengthTextBox.Text))
            {
                MessageBox.Show("Invalid dimensions. Please enter positive numeric values.");
                return;
            }

            if (!ValidateMaterial(MaterialComboBox.SelectedItem))
            {
                MessageBox.Show("Invalid material. Please select a valid material option.");
                return;
            }


            // Create a new instance of Cage and populate its properties
            Cage newCage = new Cage
            {
                Id = Guid.NewGuid().ToString(),
                UserId = UserStore.Id, // provide the appropriate value for the UserId property,
                Height = height,
                Width = width,
                Length = length,
                Material = material
            };

            database.Cages.Add(newCage);
            databaseService.WriteData(database);
            // Clear the form controls or show a success message
            ClearForm();
            MessageBox.Show("Cage added successfully!");
        }


        private void ClearForm()
        {

            HeightTextBox.Text = string.Empty;
            WidthTextBox.Text = string.Empty;
            LengthTextBox.Text = string.Empty;
            MaterialComboBox.SelectedIndex = -1; // Clear the selected material
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidateDimension(string dimension)
        {
            double value;
            return double.TryParse(dimension, out value) && value > 0;
        }

        private bool ValidateMaterial(object material)
        {
            // Validate the selected material option
            // Modify this method based on your specific material options
            if (material is Material selectedMaterial)
            {
                return selectedMaterial == Material.Iron || selectedMaterial == Material.Wood || selectedMaterial == Material.Plastic;
            }

            return false;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckChars(e);
        }

        private static void CheckChars(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                // Allow control characters (e.g., Backspace) to be entered
                return;
            }

            // Check if the entered key is a digit
            if (!char.IsDigit(e.KeyChar))
            {
                // Prevent non-numeric characters from being entered
                e.Handled = true;
            }
        }
    }
}
