using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMI.Models
{
    public class EFPersonRepository : IPersonRepository
    {
        private ApplicationDbContext context;

        public EFPersonRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Person> Persons => context.Persons;
    }
}
