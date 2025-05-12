using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astro_app
{
    internal class PlanetInfo
    {
        public Planet Planet { get; set; }
        public double YearLengthInDays { get; set; }    // rok planety w ziemskich dniach
        public double DayLengthInHours { get; set; }    // doba planety w ziemskich godzinach

        public PlanetInfo(Planet planet, double yearLengthInDays, double dayLengthInYears) 
        {
            Planet = planet;
            YearLengthInDays = yearLengthInDays;
            DayLengthInHours = dayLengthInYears;
        }
    }
}
