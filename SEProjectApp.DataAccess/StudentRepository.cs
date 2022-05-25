using SEProjectApp.Abstractions.Repository;
using SEProjectApp.DataModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(SEProjectAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
