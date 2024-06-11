namespace UniTools.Models.Weight
{
    /// <summary>
    /// Represents an imperial weight.
    /// </summary>
    public struct ImperialWeight
    {
        /// <summary>
        /// Gets the value of the weight in ounces.
        /// </summary>
        public double Ounces;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImperialWeight"/> struct.
        /// </summary>
        /// <param name="ounces">The value of the weight in ounces.</param>
        public ImperialWeight(double ounces)
        {
            Ounces = ounces;
        }

        /// <summary>
        /// Converts the weight to pounds.
        /// </summary>
        /// <returns>The weight in pounds.</returns>
        public double ToPounds()
        {
            return Ounces / 16;
        }

        /// <summary>
        /// Converts the weight to stones.
        /// </summary>
        /// <returns>The weight in stones.</returns>
        public double ToStones()
        {
            return Ounces * 0.0625;
        }

        /// <summary>
        /// Converts the weight to quarters.
        /// </summary>
        /// <returns>The weight in quarters.</returns>
        public double ToQuarters()
        {
            return Ounces * 0.03125;
        }

        /// <summary>
        /// Converts the weight to ounces.
        /// </summary>
        /// <returns>The weight in ounces.</returns>
        public double ToOunces()
        {
            return Ounces;
        }
    }
}