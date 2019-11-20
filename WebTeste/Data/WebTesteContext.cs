﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebTeste.Models.ViewModels;

namespace WebTeste.Models
{
    public class WebTesteContext : DbContext
    {
        public WebTesteContext (DbContextOptions<WebTesteContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Sellers> Sellers { get; set; }

    }
}
