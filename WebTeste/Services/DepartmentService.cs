using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTeste.Models;
using WebTeste.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace WebTeste.Services
{
    public class DepartmentService
    {
        private readonly WebTesteContext _context;

        public DepartmentService(WebTesteContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAssync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
