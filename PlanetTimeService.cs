using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace astro_app
{
    internal class PlanetTimeService
    {
        private Dictionary <Planet, PlanetInfo> _planets;

        public PlanetTimeService()
        {
            _planets = new Dictionary<Planet, PlanetInfo>
            {
                { Planet.Mercury, new PlanetInfo(Planet.Mercury, 87.97, 1407.5) },
                { Planet.Venus, new PlanetInfo(Planet.Venus, 224.7, 5832.5) },
                { Planet.Earth, new PlanetInfo(Planet.Earth, 365.25, 24) },
                { Planet.Mars, new PlanetInfo(Planet.Mars, 687, 24.67) },
                { Planet.Jupiter, new PlanetInfo(Planet.Jupiter, 4332.59, 9.93) },
                { Planet.Saturn, new PlanetInfo(Planet.Saturn, 10759.22, 10.7) },
                { Planet.Uranus, new PlanetInfo(Planet.Uranus, 30685.4, 17.24) },
                { Planet.Neptune, new PlanetInfo(Planet.Neptune, 60190, 16.11) }
            };
        }

        public DateTime GetPlanetDate(Planet planet)
        {
            DateTime now = DateTime.Now;
            DateTime j2000 = new DateTime(2000, 1, 1);

            var planetInfo = _planets[planet];

            // 1. Ile ziemskich dni minęło od J2000
            double earthDaysSinceJ2000 = (now - j2000).TotalDays;

            // 2. Ile ziemskich dni trwa jeden rok planety
            double planetYearInEarthDays = planetInfo.YearLengthInDays;

            // 3. Ile ziemskich dni trwa jedna doba planety
            double planetDayInEarthDays = planetInfo.DayLengthInHours / 24.0;

            // 4. Ile pełnych lat planetarnych minęło
            int planetYears = (int)(earthDaysSinceJ2000 / planetYearInEarthDays);

            // 5. Ile dni zostało po odjęciu pełnych lat
            double daysAfterYears = earthDaysSinceJ2000 % planetYearInEarthDays;

            // 6. Ile pełnych planetarnych dni minęło w bieżącym roku planety
            int planetDays = (int)(daysAfterYears / planetDayInEarthDays);

            DateTime result = j2000.AddDays(planetDays).AddYears(planetYears);
            return result;
        }
    }
}
