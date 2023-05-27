using System;
using System.Linq;

namespace ParootsManagement.Models
{

    public class Bird : BirdPhisicalFeatures
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Specie { get; set; }
        public string SubSpecie { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string CageId { get; set; }
        public int FatherIdentificationNumber { get; set; }
        public int MotherIdentificationNumber { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Species: {Specie}, Subspecies: {SubSpecie}, BirthDate: {BirthDate.ToShortDateString()}\n, Gender: {Gender}, CageNumber: {CageId}, FatherID: {FatherIdentificationNumber}, MotherID: {MotherIdentificationNumber}";
        }
        public int GenerateBirdId(Database db)
        {
            if (db.Birds != null && db.Birds.Count > 0)
            {
                int maxId = db.Birds.Max(bird => bird.Id);
                return maxId + 1;
            }
            else
            {
                // If there are no birds in the database yet, start with Id = 1
                return 1;
            }
        }
    }
}
