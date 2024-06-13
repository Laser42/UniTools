namespace UniTools.Models.Volume
{
    /// <summary>
    /// Represents an imperial volume.
    /// </summary>
    public struct ImperialVolume
    {
        /// <summary>
        /// Gets the value of the volume in fluid ounces.
        /// </summary>
        public double FluidOunces;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImperialVolume"/> struct.
        /// </summary>
        /// <param name="fluidOunces">The value of the volume in fluid ounces.</param>
        public ImperialVolume(double fluidOunces)
        {
            FluidOunces = fluidOunces;
        }

        /// <summary>
        /// Converts the volume to pints.
        /// </summary>
        /// <returns>The volume in pints.</returns>
        public double ToPints()
        {
            return FluidOunces / 20;
        }

        /// <summary>
        /// Converts the volume to quarts.
        /// </summary>
        /// <returns>The volume in quarts.</returns>
        public double ToQuarts()
        {
            return FluidOunces / 40;
        }

        /// <summary>
        /// Converts the volume to gallons.
        /// </summary>
        /// <returns>The volume in gallons.</returns>
        public double ToGallons()
        {
            return FluidOunces / 160;
        }

        /// <summary>
        /// Converts the volume to fluid ounces.
        /// </summary>
        /// <returns>The volume in fluid ounces.</returns>
        public double ToFluidOunces()
        {
            return FluidOunces;
        }
    }
}

