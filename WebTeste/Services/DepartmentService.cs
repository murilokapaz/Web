using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTeste.Models;
using WebTeste.Models.ViewModels;

namespace WebTeste.Services
{
    public class DepartmentService
    {
        private readonly WebTesteContext _context;

        public DepartmentService(WebTesteContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
