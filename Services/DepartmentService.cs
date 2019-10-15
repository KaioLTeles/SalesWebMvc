using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> findAllAsyn()
        {
            //Buscando a lista de departamentos ordenada por Nome.
            //return _context.Department.OrderBy(x => x.Name).ToList(); maneira sincrona de buscar dados

            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); //Chamada assincrona.
        }


    }
}
