using System;
using UniTools.Extensions.Length;
using UniTools.Models.Length;

namespace UniTools
{
    /// <summary>
    /// Demostration class
    /// </summary>
    public static class Demo
    {
        /// <summary>
        /// Performs some demo converts.
        /// </summary>
        public static void Convert()
        {
            var imperialLengthInches = MetricLength.FromMicrometers(1.0)
                .ConvertToImperial()
                .ToInches();

            Console.WriteLine(imperialLengthInches);
        }
    }
}
