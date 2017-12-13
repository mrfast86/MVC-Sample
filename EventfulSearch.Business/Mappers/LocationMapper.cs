using EventfulSearch.Business.EntitiesImplementation;
using Data = EventfulSearch.Data.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Business.Mappers
{
    static class MapperExtensions
    {
        internal static Location MapTo(this Data.DataEntities.RootObject geoCodeObject)
        {
            if (geoCodeObject == null || !geoCodeObject.results.Any())
                return null;

            return new Location
            {
                Latitude = geoCodeObject.results.FirstOrDefault().geometry.location.lat.ToString(),
                Longitude = geoCodeObject.results.FirstOrDefault().geometry.location.lng.ToString()
            };
        }
    }
}
