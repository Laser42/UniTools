using UniTools.Models.Volume;

namespace UniTools.Extensions.Volume
{
    /// <summary>
    /// Extension methods for converting between Metric and Imperial units of volume.
    /// </summary>
    public static class MetricVolumeExtensions
    {
        /// <summary>
        /// Converts the volume to an ImperialVolume instance.
        /// </summary>
        /// <param name="metricVolume">The MetricVolume instance to convert.</param>
        /// <returns>An ImperialVolume instance representing the same volume in fluid ounces.</returns>
        public static ImperialVolume ConvertToImperial(this MetricVolume metricVolume)
        {
            double fluidOunces = metricVolume.ToLiters() * 33.814; // 1 liter = 33.814 fluid ounces
            return new ImperialVolume(fluidOunces);
        }
    }
}
