namespace UniTools.Models.Volume
{
    /// <summary>
    /// Represents a metric volume.
    /// </summary>
    public struct MetricVolume
    {
        /// <summary>
        /// Gets the value of the volume in milliliters.
        /// </summary>
        public double Milliliters;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricVolume"/> struct.
        /// </summary>
        /// <param name="milliliters">The value of the volume in milliliters.</param>
        public MetricVolume(double milliliters)
        {
            Milliliters = milliliters;
        }

        /// <summary>
        /// Converts the volume to liters.
        /// </summary>
        /// <returns>The volume in liters.</returns>
        public double ToLiters()
        {
            return Milliliters / 1000;
        }

        /// <summary>
        /// Converts the volume to cubic meters.
        /// </summary>
        /// <returns>The volume in cubic meters.</returns>
        public double ToCubicMeters()
        {
            return Milliliters / 1000000;
        }

        /// <summary>
        /// Converts the volume to cubic centimeters.
        /// </summary>
        /// <returns>The volume in cubic centimeters.</returns>
        public double ToCubicCentimeters()
        {
            return Milliliters;
        }

        /// <summary>
        /// Converts the volume to milliliters.
        /// </summary>
        /// <returns>The volume in milliliters.</returns>
        public double ToMilliliters()
        {
            return Milliliters;
        }
    }
}
