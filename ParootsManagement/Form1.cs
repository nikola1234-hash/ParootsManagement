using ParootsManagement.Models;
using ParootsManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ParootsManagement
{
    public partial class Form1 : Form
    {
        private Database database;
        private DatabaseService databaseService;
        private BirdSearchService birdSearchService;
        private CageSearchService cageSearchService;
        bool? isBirdSearch = null;
        private Bird _selectedBird;

        public Bird SelectedBird
        {
            get { return _selectedBird; }
            set
            {
                _selectedBird = value;
                if (selectedBird == null && SelectedCage == null)
                {
                    editButton.Visible = false;
                }
            }
        }

        Bird selectedBird = null;
        private Cage _selectedCage;

        public Cage SelectedCage
        {
            get { return _selectedCage; }
            set
            {
                _selectedCage = value;
                if (selectedBird == null && SelectedCage == null)
                {
                    editButton.Visible = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            databaseService = new DatabaseService();
            database = new Database();
            searchPanel.Hide();
            LoadDatabase();
            resultDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            editButton.Visible = false;
            resultDataGrid.SelectionChanged += ResultDataGrid_SelectionChanged;
            birdsGroupBox.Visible = false;
            this.FormClosing += Form1_FormClosing;
            birdsInCageListBox.ItemHeight = 20;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDatabase();
            Environment.Exit(0);
        }

        private void ResultDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (isBirdSearch == null)
            {
                return;
            }
            DataGridViewRow selectedRow = null;
            if (sender is DataGridView rdg)
            {
                try
                {
                    selectedRow = resultDataGrid.SelectedRows[0];
                }
                catch (Exception ec)
                {

                    //ignore
                }
                if (selectedRow == null)
                {
                    return;
                }

                if ((bool)isBirdSearch)
                {
                    var birdId = selectedRow.Cells["Id"].Value as int?;
                    if (birdId == null)
                    {
                        // Stay in table 
                        return;

                    }

                    var bird = database.Birds.FirstOrDefault(s => s.Id == (int)birdId);
                    SelectedBird = bird;
                    SelectedCage = null;
                    editButton.Visible = true;
                    birdsGroupBox.Visible = false;
                }
                else
                {
                    List<Bird> birdsInCage = new List<Bird>();
                    var cageId = selectedRow.Cells["Id"].Value as string;
                    if (cageId == null)
                    {
                        // Stay on table
                        return;

                    }
                    var cage = database.Cages.FirstOrDefault(s => s.Id == cageId);

                    birdsInCageListBox.Items.Clear();
                    var birdIds = database.Cages.FirstOrDefault(s => s.Id == cage.Id).BirdIds;
                    if (birdIds.Count > 0)
                    {
                        birdsGroupBox.Visible = true;
                        foreach (var id in birdIds)
                        {
                            var bird = database.Birds.FirstOrDefault(s => s.Id == id);
                            if (bird != null)
                            {
                                birdsInCageListBox.Items.Add(bird);

                            }

                        }
                    }
                    SelectedCage = cage;
                    SelectedBird = null;
                    editButton.Visible = true;
                }


            }
        }

        private void InitializeBirdDataGrids()
        {
            // Add columns to the DataGridView
            resultDataGrid.Columns.Add("Id", "ID");
            resultDataGrid.Columns.Add("Species", "Species");
            resultDataGrid.Columns.Add("BirthDate", "Birth Date");
            resultDataGrid.Columns.Add("Gender", "Gender");
        }
        private void InitializeCageDataGrids()
        {
            resultDataGrid.Columns.Add("Id", "ID");
            resultDataGrid.Columns.Add("Material", "Material");
            resultDataGrid.Columns.Add("Height", "Height");
            resultDataGrid.Columns.Add("Width", "Width");
            resultDataGrid.Columns.Add("Length", "Length");
        }
        private void InitializeBirdComboBox()
        {
            // Add search criteria options to the ComboBox
            criteriaComboBox.Items.Add("Id");
            criteriaComboBox.Items.Add("Species");
            criteriaComboBox.Items.Add("Birth Date");
            criteriaComboBox.Items.Add("Gender");
        }
        private void InitializeCageComboBox()
        {
            criteriaComboBox.Items.AddRange(new[] { "ID", "Material" });
            criteriaComboBox.SelectedIndex = 0;
        }
        private void LoadDatabase()
        {
            database = databaseService.ReadData<Database>();
            if (database == null)
            {
                MessageBox.Show("Load Database Fatal Error");
                Environment.Exit(0);
            }
            birdSearchService = new BirdSearchService(database);
            cageSearchService = new CageSearchService(database);
        }

        private void SaveDatabase()
        {
            databaseService.WriteData(database);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBirdForm birdForm = new AddBirdForm(database);
            birdForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CageForm cf = new CageForm(database);
            cf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isBirdSearch = true;
            resultDataGrid.Rows.Clear();
            resultDataGrid.Columns.Clear();
            criteriaComboBox.Items.Clear();
            InitializeBirdDataGrids();
            InitializeBirdComboBox();
            searchPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isBirdSearch = false;
            resultDataGrid.Rows.Clear();
            resultDataGrid.Columns.Clear();
            criteriaComboBox.Items.Clear();
            InitializeCageComboBox();
            InitializeCageDataGrids();

            searchPanel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveDatabase();
            Environment.Exit(0);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isBirdSearch == true)
            {
                PopulateGridBirds();
            }
            else if (isBirdSearch == false)
            {
                PopulateGridCages();
            }
            else
            {
                MessageBox.Show("Not possible to do search!");
            }

        }
        private void PopulateGridCages()
        {
            resultDataGrid.Rows.Clear();
            var cages = cageSearchService.SearchCage(keywordTextbox.Text, criteriaComboBox.Text);
            foreach (var cage in cages)
            {
                resultDataGrid.Rows.Add(cage.Id, cage.Material, cage.Height, cage.Width, cage.Length);
            }
        }
        private void PopulateGridBirds()
        {
            resultDataGrid.Rows.Clear();
            var birds = birdSearchService.SearchBird(keywordTextbox.Text, criteriaComboBox.Text);
            foreach (var bird in birds)
            {
                resultDataGrid.Rows.Add(bird.Id, bird.Specie, bird.BirthDate, bird.Gender);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (SelectedCage != null)
            {
                CageForm cf = new CageForm(SelectedCage, database);
                var result = cf.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PopulateGridCages();
                }
            }
            else if (SelectedBird != null)
            {
                AddBirdForm addBirdForm = new AddBirdForm(SelectedBird, database);
                var result = addBirdForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    PopulateGridBirds();
                }
            }
            else
            {
                MessageBox.Show("Error: No record selected!");
                return;
            }

        }
    }
}

