using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMI.Models
{
    interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }
    }
}
