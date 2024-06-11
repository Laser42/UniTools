using UniTools.Models.Length;

namespace UniTools.Extensions.Length
{
    /// <summary>
    /// Extension methods for converting between Imperial and Metric units of length.
    /// </summary>
    public static class ImperialLengthExtensions
    {
        /// <summary>
        /// Converts the length to a MetricLength instance.
        /// </summary>
        /// <param name="imperialLength">The ImperialLength instance to convert.</param>
        /// <returns>A MetricLength instance representing the same length in meters.</returns>
        public static MetricLength ConvertToMetric(this ImperialLength imperialLength)
        {
            double meters = imperialLength.Feet * 0.3048; // 1 foot = 0.3048 meters
            return new MetricLength(meters);
        }
    }
}
