using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataModule
{
    public class Professor
    {
        public Guid ProfessorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CNP { get; set; }
        public string Email_address { get; set; }
        public string Phone_number { get; set; }
        public ICollection<Subject>? Subjects { get; set; }
    }
}
