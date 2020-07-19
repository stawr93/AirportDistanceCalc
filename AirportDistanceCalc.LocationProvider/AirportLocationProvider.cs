using System;
using System.Threading.Tasks;
using AirportDistanceCalc.Core;
using Geolocation;

namespace AirportDistanceCalc.LocationProvider
{
    public class AirportLocationProvider : IAirportLocationProvider
    {
        private readonly AirportsService _airportsService;

        public AirportLocationProvider(IAirportLocationProviderConfig config)
        {
            _airportsService = new AirportsService(config.ServiceUrl);
        }

        public async Task<Coordinate> LocationOf(IataAirportCode airportCode)
        {
            var airportInfo = await _airportsService.GetAirportInfo(airportCode.Value);
            return new Coordinate(airportInfo.Location.Lat, airportInfo.Location.Lon);
        }
    }
}