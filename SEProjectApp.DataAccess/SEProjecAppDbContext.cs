using Microsoft.EntityFrameworkCore;
using SEProjectApp.DataModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class SEProjectAppDbContext: DbContext
    {
        public SEProjectAppDbContext(DbContextOptions<SEProjectAppDbContext> options): base(options)
        { }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Grade> Grades { get; set; } 

    }
}
