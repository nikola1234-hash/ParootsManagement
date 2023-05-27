using System;

namespace ParootsManagement.Models
{
    public enum HeadColor
    {
        Red,
        Black,
        Yellow
    }
    public enum BodyColor
    {
        Green,
        Yellow,
        Blue,
        Silver,
        Dilute,    // Male only
        Pastel     // Male only
    }

    public enum BreastColor
    {
        Purple,
        White,
        Lilac
    }
    public enum Factor
    {
        SF,
        DF
    }

    public class Bird
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
        public BodyColor BodyColor { get; set; }
        public Factor BodyFactor { get; set; }
        public bool IsSplitBody { get; set; } // if the bird is split for the BodyColor
        public HeadColor HeadColor { get; set; }
        public Factor HeadFactor { get; set; }
        public bool IsSplitHead { get; set; } // if the bird is split for the HeadColor
        public BreastColor BreastColor { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Species: {Specie}, Subspecies: {SubSpecie}, BirthDate: {BirthDate.ToShortDateString()}\n, Gender: {Gender}, CageNumber: {CageId}, FatherID: {FatherIdentificationNumber}, MotherID: {MotherIdentificationNumber}";
        }
    }
}
