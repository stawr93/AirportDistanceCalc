namespace AirportDistanceCalc.LocationProvider
{
    internal class AirportInfo
    {
        public string Iata { get; set; }

        public string Country { get; set; }

        public string CountryIata { get; set; }

        public string City { get; set; }

        public string CityIata { get; set; }

        public string TimezoneRegionName { get; set; }

        public string Rating { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Hubs { get; set; }

        public AirportLocation Location { get; set; }
    }
}