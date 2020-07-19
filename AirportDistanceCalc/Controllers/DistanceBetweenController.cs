using System.Threading.Tasks;
using AirportDistanceCalc.Core;
using Microsoft.AspNetCore.Mvc;

namespace AirportDistanceCalc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceBetween : ControllerBase
    {
        private readonly AirportDistanceCalculator _distanceCalculator;

        public DistanceBetween(AirportDistanceCalculator distanceCalculator)
        {
            _distanceCalculator = distanceCalculator;
        }

        [HttpGet]
        public async Task<double> Get(string origin, string destination)
        {
            var originCode = new IataAirportCode(origin);
            var destinationCode = new IataAirportCode(destination);

            return await _distanceCalculator.DistanceBetween(originCode, destinationCode);
        }
    }
}