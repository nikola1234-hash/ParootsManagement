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
    public partial class AddChildForm : Form
    {

        private Database db;
        private Bird parent;
        Bird child;


        public AddChildForm(Database database, Bird parent)
        {

            InitializeComponent();
            db = database;
            this.parent = parent;
            child = new Bird();
            motherCombobox.Visible = false;
            fatherComboBox.Visible = false;
            InitializeChild();
            PopulateComboBoxes();

        }

        private void InitializeChild()
        {
            if (parent.Gender == "Male")
            {
                child.FatherIdentificationNumber = parent.Id;
                fatherId.Text = parent.Id.ToString();
                fatherId.ReadOnly = true;
                motherCombobox.Visible = true;
                motherId.Visible = false;
                motherId.Enabled = false;
                var listOfMothers = db.Birds.Where(s => s.Gender.ToLower() == "female" && s.CageId == parent.CageId);
                motherCombobox.ValueMember = "Id";
                motherCombobox.DisplayMember = "Id";
                motherCombobox.SelectedIndexChanged += MotherCombobox_SelectedIndexChanged;
                foreach (var mother in listOfMothers)
                {
                    motherCombobox.Items.Add(mother);
                }

            }
            else
            {
                child.MotherIdentificationNumber = parent.Id;
                motherId.Text = parent.Id.ToString();
                motherId.ReadOnly = true;
                fatherComboBox.Visible = true;
                fatherId.Visible = false;
                fatherId.Enabled = false;
                var listOfFathersInCage = db.Birds.Where(s => s.Gender.ToLower() == "male" && s.CageId == parent.CageId);
                fatherComboBox.ValueMember = "Id";
                fatherComboBox.DisplayMember = "Id";
                fatherComboBox.SelectedIndexChanged += FatherComboBox_SelectedIndexChanged;
                foreach (var father in listOfFathersInCage)
                {
                    fatherComboBox.Items.Add(father);


                }

            }
            child.Specie = parent.Specie;
            child.SubSpecie = parent.SubSpecie;
            child.CageId = parent.CageId;
            child.UserId = UserStore.Id;


        }

        private void MotherCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            child.MotherIdentificationNumber = ((Bird)motherCombobox.SelectedItem).Id;
            var mother = db.Birds.FirstOrDefault(s => s.Id == child.MotherIdentificationNumber);
            child.HeadColor = BirdColorService.DetermineHeadColor(parent, mother);
            child.BodyColor = BirdColorService.DetermineBodyColor(parent, mother);
            child.BreastColor = BirdColorService.DetermineBreastColor(parent, mother);
            headCombo.SelectedItem = child.HeadColor;
            bodyCombo.SelectedItem = child.BodyColor;
            breastCombo.SelectedItem = child.BreastColor;
        }

        private void FatherComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            child.FatherIdentificationNumber = ((Bird)fatherComboBox.SelectedItem).Id;
            var father = db.Birds.FirstOrDefault(s => s.Id == child.FatherIdentificationNumber);
            child.HeadColor = BirdColorService.DetermineHeadColor(parent, father);
            child.BodyColor = BirdColorService.DetermineBodyColor(parent, father);
            child.BreastColor = BirdColorService.DetermineBreastColor(parent, father);
            headCombo.SelectedItem = child.HeadColor.ToString();
            bodyCombo.SelectedItem = child.BodyColor.ToString();
            breastCombo.SelectedItem = child.BreastColor.ToString();
        }

        private void PopulateComboBoxes()
        {
            // Populate the specie ComboBox
            specieComboBox.Items.AddRange(Enum.GetNames(typeof(Specie)));
            subSpecieComboBox.Items.AddRange(Enum.GetNames(typeof(SubSpecie)));
            genderComboBox.Items.AddRange(Enum.GetNames(typeof(Gender)));
            headCombo.Items.AddRange(Enum.GetNames(typeof(HeadColor)));
            bodyCombo.Items.AddRange(Enum.GetNames(typeof(BodyColor)));
            breastCombo.Items.AddRange(Enum.GetNames(typeof(BreastColor)));

            cageNumberTextBox.Text = parent.CageId.ToString();
            specieComboBox.SelectedItem = child.Specie.ToString();
            subSpecieComboBox.SelectedItem = child.SubSpecie.ToString();


        }

        private void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            child.BirthDate = (DateTime)birthDatePicker.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            child.Id = child.GenerateBirdId(db);
            db.Birds.Add(child);
            var cage = db.Cages.FirstOrDefault(s => s.Id == child.CageId);
            cage.BirdIds.Add(child.Id);
            this.Close();
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            child.Gender = genderComboBox.SelectedItem.ToString();
        }
    }
}
