using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public enum Gender
    {
        Male,
        Female
    }
    public abstract class BirdPhisicalFeatures
    {
        public BodyColor BodyColor { get; set; }
        public Factor BodyFactor { get; set; }
        public bool IsSplitBody { get; set; } // if the bird is split for the BodyColor
        public HeadColor HeadColor { get; set; }
        public Factor HeadFactor { get; set; }
        public bool IsSplitHead { get; set; } // if the bird is split for the HeadColor
        public BreastColor BreastColor { get; set; }
    }
}
