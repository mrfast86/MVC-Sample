using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Common.Entities
{
    public interface IEventfulSearch
    {
        string Image { get; set; }
        string Title { get; set; }
        string Venue { get; set; }
        string Url { get; set; }
        string Teams { get; set; }
        string Date { get; set; }
    }
}
