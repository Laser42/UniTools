namespace UniTools.Models.Length
{
    /// <summary>
    /// Represents a length measurement in meters.
    /// </summary>
    public struct MetricLength
    {
        /// <summary>
        /// Gets the value of the length in meters.
        /// </summary>
        public double Meters { get; }

        /// <summary>
        /// Initializes a new instance of the Length struct with the specified value in meters.
        /// </summary>
        /// <param name="meters">The value of the length in meters.</param>
        public MetricLength(double meters)
        {
            Meters = meters;
        }

        /// <summary>
        /// Converts the length to kilometers.
        /// </summary>
        /// <returns>The equivalent length in kilometers.</returns>
        public double ToKilometers()
        {
            return Meters / 1000; // 1 kilometer = 1000 meters
        }

        /// <summary>
        /// Converts the length to nanometers.
        /// </summary>
        /// <returns>The equivalent length in nanometers.</returns>
        public double ToNanometers()
        {
            return Meters * 1e9; // 1 nanometer = 1e-9 meters
        }

        /// <summary>
        /// Converts the length to micrometers.
        /// </summary>
        /// <returns>The equivalent length in micrometers.</returns>
        public double ToMicrometers()
        {
            return Meters * 1e6; // 1 micrometer = 1e-6 meters
        }

        /// <summary>
        /// Converts the length to decimeters.
        /// </summary>
        /// <returns>The equivalent length in decimeters.</returns>
        public double ToDecimeters()
        {
            return Meters * 10; // 1 decimeter = 0.1 meters
        }

        /// <summary>
        /// Converts the length to centimeters.
        /// </summary>
        /// <returns>The equivalent length in centimeters.</returns>
        public double ToCentimeters()
        {
            return Meters * 100; // 1 centimeter = 0.01 meters
        }

        /// <summary>
        /// Converts the length to meters.
        /// </summary>
        /// <returns>The equivalent length in meters.</returns>
        public double ToMeters()
        {
            return Meters;
        }

        /// <summary>
        /// Creates a Length instance from the specified value in kilometers.
        /// </summary>
        /// <param name="kilometers">The value of the length in kilometers.</param>
        public static MetricLength FromKilometers(double kilometers)
        {
            return new MetricLength(kilometers * 1000); // 1 kilometer = 1000 meters
        }

        /// <summary>
        /// Creates a Length instance from the specified value in nanometers.
        /// </summary>
        /// <param name="nanometers">The value of the length in nanometers.</param>
        public static MetricLength FromNanometers(double nanometers)
        {
            return new MetricLength(nanometers / 1e9); // 1 nanometer = 1e-9 meters
        }

        /// <summary>
        /// Creates a Length instance from the specified value in micrometers.
        /// </summary>
        /// <param name="micrometers">The value of the length in micrometers.</param>
        public static MetricLength FromMicrometers(double micrometers)
        {
            return new MetricLength(micrometers / 1e6); // 1 micrometer = 1e-6 meters
        }

        /// <summary>
        /// Creates a Length instance from the specified value in decimeters.
        /// </summary>
        /// <param name="decimeters">The value of the length in decimeters.</param>
        public static MetricLength FromDecimeters(double decimeters)
        {
            return new MetricLength(decimeters / 10); // 1 decimeter = 0.1 meters
        }

        /// <summary>
        /// Creates a Length instance from the specified value in centimeters.
        /// </summary>
        /// <param name="centimeters">The value of the length in centimeters.</param>
        public static MetricLength FromCentimeters(double centimeters)
        {
            return new MetricLength(centimeters / 100); // 1 centimeter = 0.01 meters
        }
    }
}