using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Professor Advisor { get; set; }
        public List<int> CourseIds { get; set; } = new List<int>();
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
