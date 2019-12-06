﻿using System;
using System.Collections.Generic;
using System.Linq;
using WebTeste.Services.Exceptions;
using WebTeste.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebTeste.Services
{
    public class SellerService
    {
        private readonly WebTesteContext _context;

        public SellerService(WebTesteContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {

            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Seller> FindByIdAsync(int id)
        {

            return await _context.Seller.Include(obj=>obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);//retorna o id ou nulo
        }
        public async Task RemoveAsync(int id)
        {
            try
            {

                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityExceptions(e.Message);
            }
        }
            public async Task UpdateAsync(Seller obj)
            {
                if(!(await _context.Seller.AnyAsync(x=>x.Id == obj.Id)))
                {
                    throw new NotFoundException("Id Not Found!");
                }
                try
                {
                    _context.Update(obj);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException e)
                {
                    throw new DbConcurrencyException(e.Message);
                }
            }
    }
}
