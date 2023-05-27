using ParootsManagement.Models;
using ParootsManagement.Services;
using System;
using System.Windows.Forms;

namespace ParootsManagement
{
    public partial class Form1 : Form
    {
        private Database database;
        private DatabaseService databaseService;
        private BirdSearchService birdSearchService;
        public Form1()
        {
            InitializeComponent();
            databaseService = new DatabaseService();
            database = new Database();
            birdSearchService = new BirdSearchService(database);
            LoadDatabase();
            InitializePanels();

        }

        private void InitializePanels()
        {
            searchBirdPanel.Hide();
            searchCagePanel.Hide();
        }

        private void LoadDatabase()
        {
            database = databaseService.ReadData<Database>();
            if (database == null)
            {
                database = new Database();
            }
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
            searchBirdPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchCagePanel.Show();
        }
    }
}
