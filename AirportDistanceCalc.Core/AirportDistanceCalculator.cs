using System.Threading.Tasks;
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

        public async Task<double> DistanceBetween(IataAirportCode origin, IataAirportCode dest)
        {
            var originLocation = await _airportLocationProvider.LocationOf(origin);
            var destLocation = await _airportLocationProvider.LocationOf(dest);

            var distance = GeoCalculator.GetDistance(originLocation, destLocation, distanceUnit:DistanceUnit.Kilometers);

            return distance;
        }
    }
}