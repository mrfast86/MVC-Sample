using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Common.Entities
{
    public interface ILocation
    {
        string Latitude { get; set; }
        string Longitude { get; set; }
    }
}
