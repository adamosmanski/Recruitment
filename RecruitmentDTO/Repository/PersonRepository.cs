using RecruitmentDTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentDTO.Repository
{
    public class PersonRepository
    {
        public PersonRepository(TasksContext _context)
        {
            context = _context;
        }
        private TasksContext context;

        public IEnumerable<Osoby> GettAllPerson()
        {
            var persons = context.Osobies.ToList();
            return persons;
        }

    }
}
