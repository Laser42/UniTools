namespace UniTools.Models.Length
{
    /// <summary>
    /// Represents a length measurement in imperial units.
    /// </summary>
    public struct ImperialLength
    {
        /// <summary>
        /// Gets the value of the length in feet.
        /// </summary>
        public double Feet { get; }

        /// <summary>
        /// Initializes a new instance of the ImperialLength struct with the specified value in feet.
        /// </summary>
        /// <param name="feet">The value of the length in feet.</param>
        public ImperialLength(double feet)
        {
            Feet = feet;
        }

        /// <summary>
        /// Converts the length to inches.
        /// </summary>
        /// <returns>The equivalent length in inches.</returns>
        public double ToInches()
        {
            return Feet * 12; // 1 foot = 12 inches
        }

        /// <summary>
        /// Converts the length to yards.
        /// </summary>
        /// <returns>The equivalent length in yards.</returns>
        public double ToYards()
        {
            return Feet / 3; // 1 yard = 3 feet
        }

        /// <summary>
        /// Converts the length to miles.
        /// </summary>
        /// <returns>The equivalent length in miles.</returns>
        public double ToMiles()
        {
            return Feet / 5280; // 1 mile = 5280 feet
        }

        /// <summary>
        /// Creates an ImperialLength instance from the specified value in inches.
        /// </summary>
        /// <param name="inches">The value of the length in inches.</param>
        public static ImperialLength FromInches(double inches)
        {
            return new ImperialLength(inches / 12); // 1 foot = 12 inches
        }

        /// <summary>
        /// Creates an ImperialLength instance from the specified value in yards.
        /// </summary>
        /// <param name="yards">The value of the length in yards.</param>
        public static ImperialLength FromYards(double yards)
        {
            return new ImperialLength(yards * 3); // 1 yard = 3 feet
        }

        /// <summary>
        /// Creates an ImperialLength instance from the specified value in miles.
        /// </summary>
        /// <param name="miles">The value of the length in miles.</param>
        public static ImperialLength FromMiles(double miles)
        {
            return new ImperialLength(miles * 5280); // 1 mile = 5280 feet
        }
    }
}
