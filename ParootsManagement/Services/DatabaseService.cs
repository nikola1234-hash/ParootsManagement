using Newtonsoft.Json;
using ParootsManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParootsManagement.Services
{
    public class DatabaseService
    {
        private string databaseFilePath;
        private string databaseName = "database.json";
        private bool isFirstTime = false;
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
                isFirstTime = true;
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
            try
            {
                Database db = null;
                if (isFirstTime)
                {
                    db = new Database();
                    isFirstTime = false;
                }
                else
                {
                    db = ReadData<Database>();
                }
                if (data.Birds != null)
                {
                    foreach (var bird in data.Birds)
                    {
                        foreach (var dbbird in db.Birds)
                        {
                            if (bird.Id == dbbird.Id)
                            {
                                continue;
                            }
                            else
                            {
                                bird.Id = GetNextId(data.Birds);
                            }
                        }

                    }
                }

                if (data.Cages != null)
                {
                    foreach (var cage in data.Cages)
                    {
                        foreach (var dbCage in db.Cages)
                        {
                            if (cage.Id == dbCage.Id)
                                continue;
                            else
                                cage.Id = cage.Id;
                        }

                    }
                }

                // Write the data to the file
                string json = JsonConvert.SerializeObject(data);
                File.WriteAllText(databaseFilePath, json);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
