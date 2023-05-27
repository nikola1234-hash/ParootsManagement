using ParootsManagement.Const;
using ParootsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParootsManagement.Services
{
    public class BirdSearchService
    {
        private Database database;
        private List<Bird> birdList;
        public BirdSearchService(Database database)
        {
            this.database = database;
            this.birdList = database.Birds;
        }

        public List<Bird> SearchBird(string query, string criteria)
        {


            List<Bird> searchResults = new List<Bird>();
            switch (criteria)
            {
                case "Id":
                    searchResults = SearchBirdsById(query);
                    break;
                case "Species":
                    searchResults = SearchBirdsBySpecies(query);
                    break;
                case "Birth Date":
                    if (DateTime.TryParse(query, out DateTime birthDate))
                    {
                        searchResults = SearchBirdsByBirthDate(birthDate);
                    }
                    break;
                case "Gender":
                    searchResults = SearchBirdsByGender(query);
                    break;
            }

            // Check the number of search results
            int resultCount = searchResults.Count;

            if (resultCount == 1)
            {
                return searchResults;
            }
            else if (resultCount > 1)
            {
                // Multiple results found, show them in the DataGridView
                return searchResults;
            }
            else
            {
                // No results found
                MessageBox.Show("No birds found matching the search criteria.");
                return new List<Bird>();
            }
        }
        private List<Bird> SearchBirdsById(string id)
        {
            // Perform the search by bird id
            return birdList.Where(bird => bird.Id.ToString() == id && bird.UserId == UserStore.Id).ToList();
        }

        private List<Bird> SearchBirdsBySpecies(string species)
        {
            // Perform the search by bird species
            return birdList.Where(bird => bird.Specie.Equals(species, StringComparison.OrdinalIgnoreCase) && bird.UserId == UserStore.Id).ToList();
        }

        private List<Bird> SearchBirdsByBirthDate(DateTime birthDate)
        {
            // Perform the search by bird birth date
            return birdList.Where(bird => bird.BirthDate.Date == birthDate.Date && bird.UserId == UserStore.Id).ToList();
        }

        private List<Bird> SearchBirdsByGender(string gender)
        {
            // Perform the search by bird gender
            return birdList.Where(bird => bird.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase) && bird.UserId == UserStore.Id).ToList();
        }

    }
}
