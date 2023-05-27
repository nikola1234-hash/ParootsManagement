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
            var emptyDatabase = new Database();
            WriteData(emptyDatabase);
        }

        private int GetNextId<T>(List<T> dataList)
        {
            int maxId = dataList.Max(data => GetIdValue(data));
            return maxId + 1;
        }

        private int GetIdValue<T>(T data)
        {
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null)
            {
                return (int)idProperty.GetValue(data);
            }
            return 0;
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

        public void WriteData(Database data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            // Increment the Id and ensure unique Ids
            if (data.Birds != null)
            {
                foreach (var bird in data.Birds)
                {
                    bird.Id = GetNextId(data.Birds);
                }
            }

            if (data.Cages != null)
            {
                foreach (var cage in data.Cages)
                {
                    cage.Id = cage.Id;
                }
            }

            // Write the data to the file
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(databaseFilePath, json);
        }


    }
}
