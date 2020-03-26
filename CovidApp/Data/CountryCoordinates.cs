using CovidApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApp.Data
{
    public class CountryCoordinates
    {

        public static Dictionary<string, Coords> countries = new Dictionary<string, Coords>()
        {
            { "US", new Coords(1.0, 2.0) },
            { "JP", new Coords(10.0, 20.0) },
            { "CN", new Coords(11.0, 22.0) }
        };
        
    }
}
