using Geolocation;

namespace AirportDistanceCalc.Core
{
    public interface IAirportLocationProvider
    {
        Coordinate LocationOf(IataAirportCode airportCode);
    }
}