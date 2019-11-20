using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTeste.Models;

namespace WebTeste.Services
{
    public class SellerService
    {
        private readonly WebTesteContext _context;

        public SellerService(WebTesteContext context)
        {
            _context = context;
        }

        public List<Sellers> FindAll()
        {
            return _context.Sellers.ToList();
        }
    }
}
