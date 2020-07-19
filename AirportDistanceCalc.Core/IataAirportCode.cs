using System;

namespace AirportDistanceCalc.Core
{
    /// <summary>
    /// Represents 3-letter IATA code of airport.
    /// </summary>
    public sealed class IataAirportCode
    {
        public string Value { get; }

        public IataAirportCode(string value)
        {
            if (value.Length != 3)
            {
                throw new ArgumentException("Only three letter codes allowed.");
            }

            Value = value.ToUpper();
        }
    }
}