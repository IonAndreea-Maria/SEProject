using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataModule
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CNP { get; set; }
        public string Email_address{ get; set; }
        public string Phone_number { get; set; }
        public DateTime Birth_date { get; set; }

        public ICollection<Subject>? Grades { get; set; }

    }
}
