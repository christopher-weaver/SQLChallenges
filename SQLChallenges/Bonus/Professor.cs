﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTenured { get; set; }
        public List<int> CourseIds { get; set; } = new List<int>();
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}