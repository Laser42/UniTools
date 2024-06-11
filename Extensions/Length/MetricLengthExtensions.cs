using UniTools.Models.Length;

namespace UniTools.Extensions.Length
{
    /// <summary>
    /// Extension methods for converting between Metric and Imperial units of length.
    /// </summary>
    public static class MetricLengthExtensions
    {
        /// <summary>
        /// Converts the length to an ImperialLength instance.
        /// </summary>
        /// <param name="metricLength">The MetricLength instance to convert.</param>
        /// <returns>An ImperialLength instance representing the same length in feet.</returns>
        public static ImperialLength ConvertToImperial(this MetricLength metricLength)
        {
            double feet = metricLength.Meters / 0.3048; // 1 foot = 0.3048 meters
            return new ImperialLength(feet);
        }
    }
}
