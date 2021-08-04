using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class Listing
    {
        // Primary key
        public Guid ListingId { get; set; }
        public DateTime DateListed { get; set; }
        public bool IsRental { get; set; }

        // Foreign key
        public Guid HouseId { get; set; }
        public House House { get; set; }
    }
}
