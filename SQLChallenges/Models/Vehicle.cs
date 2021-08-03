using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class Vehicle
    {
        // Primary key
        public Guid VehicleId { get; set; }
        public string licensePlate { get; set; }
        public string VIN { get; set; }
        public decimal Miles { get; set; }
    }
}
