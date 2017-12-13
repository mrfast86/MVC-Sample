using EventfulSearch.Data.DataEntities;
using System.Threading.Tasks;

namespace EventfulSearch.Data
{
    public interface IGeoCodeData
    {
        Task<RootObject> GetLocationAsync(string address);
    }
}