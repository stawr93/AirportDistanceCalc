using AirportDistanceCalc.LocationProvider;

namespace AirportDistanceCalc
{
    internal class AirportLocationProviderConfig : IAirportLocationProviderConfig
    {
        public string ServiceUrl { get; } = "https://places-dev.cteleport.com/";
    }
}