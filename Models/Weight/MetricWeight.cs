namespace UniTools.Models.Weight
{
    /// <summary>
    /// Represents a metric weight.
    /// </summary>
    public struct MetricWeight
    {
        /// <summary>
        /// Gets the value of the weight in grams.
        /// </summary>
        public double Grams;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricWeight"/> struct.
        /// </summary>
        /// <param name="grams">The value of the weight in grams.</param>
        public MetricWeight(double grams)
        {
            Grams = grams;
        }

        /// <summary>
        /// Converts the weight to kilograms.
        /// </summary>
        /// <returns>The weight in kilograms.</returns>
        public double ToKilograms()
        {
            return Grams / 1000;
        }

        /// <summary>
        /// Converts the weight to milligrams.
        /// </summary>
        /// <returns>The weight in milligrams.</returns>
        public double ToMilligrams()
        {
            return Grams * 1000;
        }

        /// <summary>
        /// Converts the weight to micrograms.
        /// </summary>
        /// <returns>The weight in micrograms.</returns>
        public double ToMicrograms()
        {
            return Grams * 1000000;
        }

        /// <summary>
        /// Converts the weight to tonnes.
        /// </summary>
        /// <returns>The weight in tonnes.</returns>
        public double ToTonnes()
        {
            return Grams / 1000000;
        }
    }
}
