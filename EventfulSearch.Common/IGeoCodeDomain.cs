using EventfulSearch.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Common
{
    public interface IGeoCodeDomain
    {
        Task<ILocation> GetLocationAsync(string address);
    }
}
