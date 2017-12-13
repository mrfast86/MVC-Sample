using EventfulSearch.Data.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = EventfulSearch.Business.EntitiesImplementation;

namespace EventfulSearch.Business.Mappers
{
    static class MapperExtensionsForEvents
    {
        internal static List<Entities.EventfulSearch> MapTo(this search result)
        {
            if (result == null)
                return null;

            List<Entities.EventfulSearch> returnList = new List<EntitiesImplementation.EventfulSearch>();
            foreach (var e in result.events)
            {
                Entities.EventfulSearch searchItem = new Entities.EventfulSearch();
                searchItem.Title = e.title;
                searchItem.Date = e.start_time;
                searchItem.Image = e.image?.FirstOrDefault()?.medium?.FirstOrDefault()?.url;
                searchItem.Teams = string.Join(",", e.performers?.Select(p => p.name).ToList());
                searchItem.Venue = e.venue_name;
                searchItem.Url = e.url;
                returnList.Add(searchItem);
            }

            return returnList;
        }
    }
}
