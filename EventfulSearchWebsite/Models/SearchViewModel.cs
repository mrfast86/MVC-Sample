using EventfulSearch.Common.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventfulSearchWebsite.Models
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public string Category { get; set; }

        [Range(0, 300, ErrorMessage = "Must be a valid decimal number between 0 and 300")]
        public float Radius { get; set; }

        public ILocation Location { get; set; }

        public IEnumerable<IEventfulSearch> SearchResults { get; set; }
    }
}