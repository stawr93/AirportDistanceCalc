using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace AirportDistanceCalc.LocationProvider
{
    internal class AirportsService
    {
        private readonly string _baseUrl;

        public AirportsService(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<AirportInfo> GetAirportInfo(string iataCode)
        {
            // TODO: handle external service errors

            var airport = await _baseUrl
                .AppendPathSegments("airports", iataCode)
                .GetJsonAsync<AirportInfo>();

            return airport;
        }
    }
}