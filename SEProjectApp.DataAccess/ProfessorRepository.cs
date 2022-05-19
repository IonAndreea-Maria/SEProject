using SEProjectApp.Abstractions.Repository;
using SEProjectApp.DataModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEProjectApp.DataAccess
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(SEProjectAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
