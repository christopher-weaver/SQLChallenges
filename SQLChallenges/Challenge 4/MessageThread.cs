using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class MessageThread
    {
        // Primary key
        public int MessageThreadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        // Foreign keys (many-to-many)
        public List<int> UserIds { get; set; } = new List<int>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
