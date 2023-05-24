using Newtonsoft.Json;
using ParootsManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParootsManagement.Services
{
    public class DatabaseService
    {
        private string databaseFilePath;
        private string databaseName = "database.json";
        public DatabaseService()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string folderPath = Path.Combine(appDataFolder, "ParootsManagement");
            Directory.CreateDirectory(folderPath);

            databaseFilePath = Path.Combine(folderPath, databaseName);
            if (!File.Exists(databaseFilePath))
            {
                CreateEmptyDatabase();
            }
        }

        private void CreateEmptyDatabase()
        {
            // Create an empty database object or initialize with default values
            var emptyDatabase = new Database();

            // Write the empty database to the file
            WriteData(emptyDatabase);
        }

        public T ReadData<T>()
        {
            if (!File.Exists(databaseFilePath))
            {
                CreateEmptyDatabase();
            }

            string json = File.ReadAllText(databaseFilePath);
            T data = JsonConvert.DeserializeObject<T>(json);
            return data;
        }

        public void WriteData<T>(T data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(databaseFilePath, json);
        }
    }
}
