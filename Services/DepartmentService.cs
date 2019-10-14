using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> findAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList(); //Buscando a lista de departamentos ordenada por Nome.
        }


    }
}
