using UniTools.Models.Weight;

namespace UniTools.Extensions.Weight
{
    /// <summary>
    /// Represents an extension method for converting an ImperialWeight instance to a MetricWeight instance.
    /// </summary>
    public static class ImperialWeightExtensions
    {
        /// <summary>
        /// Converts the weight to a MetricWeight instance.
        /// </summary>
        /// <param name="imperialWeight">The ImperialWeight instance to convert.</param>
        /// <returns>A MetricWeight instance representing the same weight in grams.</returns>
        public static MetricWeight ConvertToMetric(this ImperialWeight imperialWeight)
        {
            double grams = imperialWeight.Ounces * 28.349523125;
            return new MetricWeight(grams);
        }
    }
}
