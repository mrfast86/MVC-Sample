using EventfulSearch.Common.Entities;
using EventfulSearchWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventfulSearchWebsite.Mapper
{
    static class MapperExtensions
    {
        internal static SearchParam MapTo(this SearchViewModel model)
        {
            if (model == null)
                return null;

            return new SearchParam
            {
                Lat = model.Location.Latitude,
                Long = model.Location.Longitude,
                Address = model.Address,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                Category = model.Category,
                Radius = model.Radius
            };
        }
    }
}