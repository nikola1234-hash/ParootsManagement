﻿using ParootsManagement.Models;
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
    public partial class Form1 : Form
    {
        private Database database;
        private DatabaseService databaseService;
        public Form1()
        {
            InitializeComponent();
            LoadDatabase();
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
    }
}
