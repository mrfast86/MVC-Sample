using EventfulSearch.Common.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventfulSearch.Common
{
    public interface IEventfulSearchDomain
    {
        Task<IEnumerable<IEventfulSearch>> SearchAsync(SearchParam param);
    }
}