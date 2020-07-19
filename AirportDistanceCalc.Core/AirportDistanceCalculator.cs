using System;
using Geolocation;

namespace AirportDistanceCalc.Core
{
    public class AirportDistanceCalculator
    {
        private readonly IAirportLocationProvider _airportLocationProvider;

        public AirportDistanceCalculator(IAirportLocationProvider airportLocationProvider)
        {
            _airportLocationProvider = airportLocationProvider;
        }

        public double DistanceBetween(IataAirportCode origin, IataAirportCode dest)
        {
            var originLocation = _airportLocationProvider.LocationOf(origin);
            var destLocation = _airportLocationProvider.LocationOf(dest);

            var distance = GeoCalculator.GetDistance(originLocation, destLocation, distanceUnit:DistanceUnit.Kilometers);

            return distance;
        }
    }
}