using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class User
    {
        // Primary key
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoinedOn { get; set; }

        // Foreign keys (many-to-many)
        public List<int> MessageThreadIds { get; set; } = new List<int>();
        public List<MessageThread> MessageThreads { get; set; } = new List<MessageThread>();
    }
}
