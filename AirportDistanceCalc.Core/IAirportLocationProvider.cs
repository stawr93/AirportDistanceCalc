using System.Threading.Tasks;
using Geolocation;

namespace AirportDistanceCalc.Core
{
    public interface IAirportLocationProvider
    {
        Task<Coordinate> LocationOf(IataAirportCode airportCode);
    }
}