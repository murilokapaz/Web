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

        public void Insert(Sellers obj)
        {

            _context.Add(obj);
            _context.SaveChanges();
        }
        public Sellers FindById(int id)
        {
            return _context.Sellers.FirstOrDefault(obj => obj.Id == id);//retorna o id ou nulo
        }
        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }
    }
}
