using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventfulSearch.Common.Entities;

namespace EventfulSearch.Business.EntitiesImplementation
{
    internal class EventfulSearch : IEventfulSearch
    {
        public string Url { get; set; }

        public string Date { get; set; }

        public string Image { get; set; }

        public string Teams { get; set; }

        public string Title { get; set; }

        public string Venue { get; set; }
    }
}
