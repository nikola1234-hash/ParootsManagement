using ParootsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParootsManagement.Services
{
    public class CageSearchService
    {
        private Database database;
        private List<Cage> cage;
        public CageSearchService(Database database)
        {
            this.database = database;
            this.cage = database.Cages;
        }


        public List<Cage> SearchCage(string query, string criteria)
        {
            List<Cage> searchResults = new List<Cage>();
            switch (criteria)
            {
                case "ID":
                    searchResults = SearchById(query);
                    break;
                case "Material":
                    searchResults = SearchByMaterial(query);
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
                MessageBox.Show("No cages found matching the search criteria.");
                return new List<Cage>();
            }
        }

        private List<Cage> SearchById(string id)
        {
            List<Cage> cages = new List<Cage>();
            cages = cage.Where(s => id == id).OrderBy(s => s.Id).ToList();
            return cages;

        }
        private List<Cage> SearchByMaterial(string material)
        {
            var output = Enum.TryParse(material, out Material mat);
            if (!output)
            {
                MessageBox.Show("Failed to cast material");
                return null;

            }

            List<Cage> cages = new List<Cage>();

            cages = cage.Where(s => s.Material.ToString().ToLower() == mat.ToString().ToLower()).OrderBy(s => s.Id).ToList();


            return cages;


        }

    }
}
