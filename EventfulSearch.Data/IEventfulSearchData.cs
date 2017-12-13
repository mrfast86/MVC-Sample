using EventfulSearch.Data.DataEntities;
using System.Threading.Tasks;
using System;
using EventfulSearch.Common.Entities;

namespace EventfulSearch.Data
{
    public interface IEventfulSearchData
    {
        Task<search> SearchAsync(SearchParam searchParam);
    }
}