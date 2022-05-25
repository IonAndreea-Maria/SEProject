using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataModule
{
    public class Grade
    {  
        public DateTime Date { get; set; }
        public float Grades { get; set; }    
        public int No_credits { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public Subject Subject { get; set; }
    }
}
