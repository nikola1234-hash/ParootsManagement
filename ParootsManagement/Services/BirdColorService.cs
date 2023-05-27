using ParootsManagement.Models;
using System;

namespace ParootsManagement.Services
{
    public static class BirdColorService
    {
        public static BodyColor DetermineBodyColor(Bird parent1, Bird parent2)
        {
            // Assuming green is the dominant trait
            if (parent1.BodyColor == BodyColor.Green || parent2.BodyColor == BodyColor.Green)
            {
                return BodyColor.Green;
            }

            // If both parents have the same color, the chick will inherit that color
            if (parent1.BodyColor == parent2.BodyColor)
            {
                return parent1.BodyColor;
            }

            // If one parent is Blue and other is Yellow, the chick can be either Blue or Yellow
            if ((parent1.BodyColor == BodyColor.Blue && parent2.BodyColor == BodyColor.Yellow)
                || (parent1.BodyColor == BodyColor.Yellow && parent2.BodyColor == BodyColor.Blue))
            {
                // You might decide randomly or apply more complex rules
                return new Random().Next(2) == 0 ? BodyColor.Blue : BodyColor.Yellow;
            }



            return BodyColor.Green; // Default color
        }

        public static HeadColor DetermineHeadColor(Bird parent1, Bird parent2)
        {
            // If at least one parent has a red head, the chick will too
            if (parent1.HeadColor == HeadColor.Red || parent2.HeadColor == HeadColor.Red)
            {
                return HeadColor.Red;
            }

            // If both parents have a black head, the chick will too
            if (parent1.HeadColor == HeadColor.Black && parent2.HeadColor == HeadColor.Black)
            {
                return HeadColor.Black;
            }

            // If both parents have a yellow head and at least one parent has a red head, the chick will have a yellow head
            if (parent1.HeadColor == HeadColor.Yellow && parent2.HeadColor == HeadColor.Yellow
                && (parent1.HeadColor == HeadColor.Red || parent2.HeadColor == HeadColor.Red))
            {
                return HeadColor.Yellow;
            }



            return HeadColor.Red; // Default color
        }

        public static BreastColor DetermineBreastColor(Bird parent1, Bird parent2)
        {
            // If at least one parent has a purple breast, the chick will too
            if (parent1.BreastColor == BreastColor.Purple || parent2.BreastColor == BreastColor.Purple)
            {
                return BreastColor.Purple;
            }

            // If both parents have a white breast, the chick will too
            if (parent1.BreastColor == BreastColor.White && parent2.BreastColor == BreastColor.White)
            {
                return BreastColor.White;
            }

            // If both parents have a lilac breast, the chick will too
            if (parent1.BreastColor == BreastColor.Lilac && parent2.BreastColor == BreastColor.Lilac)
            {
                return BreastColor.Lilac;
            }



            return BreastColor.Purple; // Default color
        }
    }
}
