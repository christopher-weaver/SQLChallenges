using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class Technician
    {
        // Primary key
        public Guid TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float CustomerRating { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
