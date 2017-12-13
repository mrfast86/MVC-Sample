using EventfulSearch.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventfulSearch.Common.Entities;
using EventfulSearch.Data;
using EventfulSearch.Business.Mappers;

namespace EventfulSearch.Business
{
    internal class GeoCodeDomain : IGeoCodeDomain
    {
        public readonly IGeoCodeData _data;

        public GeoCodeDomain(IGeoCodeData data)
        {
            _data = data;
        }

        public async Task<ILocation> GetLocationAsync(string address)
        {
            if (string.IsNullOrEmpty(address))
                return null;

            var location = await _data.GetLocationAsync(address);

            return location.MapTo();
        }
    }
}
