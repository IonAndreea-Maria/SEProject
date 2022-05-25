using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataModule
{
    public class Subject
    {
        public Guid SubjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year_of_study { get; set; }
        public int Credits { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public Grade Grade { get; set; }
    }
}
