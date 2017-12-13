using EventfulSearch.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Business.EntitiesImplementation
{
    internal class Location : ILocation
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}
