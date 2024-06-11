using UniTools.Models.Weight;

namespace UniTools.Extensions.Weight
{
    /// <summary>
    /// Represents an extension method for converting a MetricWeight instance to an ImperialWeight instance.
    /// </summary>
    public static class MetricWeightExtensions
    {
        /// <summary>
        /// Converts the weight to an ImperialWeight instance.
        /// </summary>
        /// <param name="metricWeight">The MetricWeight instance to convert.</param>
        /// <returns>An ImperialWeight instance representing the same weight in ounces.</returns>
        public static ImperialWeight ConvertToImperial(this MetricWeight metricWeight)
        {
            double ounces = metricWeight.Grams / 28.349523125;
            return new ImperialWeight(ounces);
        }
    }
}
