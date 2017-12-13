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
    internal class EventfulSearchDomain : IEventfulSearchDomain
    {
        public readonly IEventfulSearchData _data;

        public EventfulSearchDomain(IEventfulSearchData data)
        {
            _data = data;
        }

        public async Task<IEnumerable<IEventfulSearch>> SearchAsync(SearchParam param)
        {
            if (param == null)
                return null;

            var results = await _data.SearchAsync(param);

            return results.MapTo();
        }
    }
}
