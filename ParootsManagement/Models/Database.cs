using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParootsManagement.Models
{
    public class Database
    {
        public List<Bird> Birds { get; set; }
        public List<Cage> Cages { get; set; }

        public Database()
        {
            Birds = new List<Bird>();
            Cages = new List<Cage>();
        }
    }
}
