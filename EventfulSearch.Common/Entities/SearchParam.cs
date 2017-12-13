using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventfulSearch.Common.Entities
{
    public class SearchParam
    {
        public string Address { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public string Category { get; set; }

        public float Radius { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }
    }
}
