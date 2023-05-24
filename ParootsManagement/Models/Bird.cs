using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParootsManagement.Models
{
    public class Bird
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Specie { get; set; }
        public string SubSpecie { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CageNumber { get; set; }
        public int FatherIdentificationNumber { get; set; }
        public int MotherIdentificationNumber { get; set; }
    }
}
