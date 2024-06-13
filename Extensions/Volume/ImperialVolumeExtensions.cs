using UniTools.Models.Volume;

namespace UniTools.Extensions.Volume
{
    /// <summary>
    /// Extension methods for converting between Imperial and Metric units of volume.
    /// </summary>
    public static class ImperialVolumeExtensions
    {
        /// <summary>
        /// Converts the volume to a MetricVolume instance.
        /// </summary>
        /// <param name="imperialVolume">The ImperialVolume instance to convert.</param>
        /// <returns>A MetricVolume instance representing the same volume in liters.</returns>
        public static MetricVolume ConvertToMetric(this ImperialVolume imperialVolume)
        {
            double liters = imperialVolume.FluidOunces / 33.814; // 1 fluid ounce = 0.0295735 liters
            return new MetricVolume(liters);
        }
    }
}
