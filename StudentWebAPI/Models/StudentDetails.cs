using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentWebAPI.Models
{
    public class StudentDetails
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Course { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}