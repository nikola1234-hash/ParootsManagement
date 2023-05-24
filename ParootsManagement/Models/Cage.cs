using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParootsManagement.Models
{
    public class Cage
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public string Material { get; set; }
        public List<int> BirdIds { get; set; }

        public Cage()
        {
            BirdIds = new List<int>();
        }
    }
}
