using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTeste.Models;
using WebTeste.Models.ViewModels;
using WebTeste.Models.Enums;

namespace WebTeste.Data
{
    public class SeedingService
    {
        private WebTesteContext _context;

        public SeedingService(WebTesteContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
               _context.Sellers.Any()|| 
               _context.SalesRecord.Any()) // verifica se não tem nada no banco
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Books");
            Department d3 = new Department(3, "Electronics");
            Department d4 = new Department(4, "Fashion");
            Department d5 = new Department(5, "Others");

            Sellers s1 = new Sellers(1, "Murilo Rerison", "murilo@gmail.com", new DateTime(1989, 09, 3), 6000.00, d1);
            Sellers s2 = new Sellers(2, "Manuel", "manuel@gmail.com", new DateTime(1988, 09, 10), 4000.00, d2);
            Sellers s3 = new Sellers(3, "Maria Dias", "maria@gmail.com", new DateTime(1999, 12, 3), 5000.00, d3);
            Sellers s4 = new Sellers(4, "Diego Sousa", "diego@gmail.com", new DateTime(2000, 09, 3), 2000.00, d4);
            Sellers s5 = new Sellers(5, "Marcelo Silva", "marcelo@gmail.com", new DateTime(1989, 09, 1), 5500.00, d5);
            Sellers s6 = new Sellers(6, "Ronaldo Carlos", "ronaldo@gmail.com", new DateTime(1989, 05, 3), 1000.00, d1);

            SalesRecord r1 = new SalesRecord {Id = 1, Date = new DateTime(2019,05,10), Amount = 15800.00, Status = SaleStatus.Canceled, Seller =s1};
            SalesRecord r2 = new SalesRecord {Id = 2, Date = new DateTime(2019,05,10), Amount = 19000.00, Status = SaleStatus.Billed, Seller = s2};
            SalesRecord r3 = new SalesRecord {Id = 3, Date = new DateTime(2019,05,10), Amount = 18600.00, Status = SaleStatus.Billed, Seller = s3};
            SalesRecord r4 = new SalesRecord {Id = 4, Date = new DateTime(2019,05,10), Amount = 18900.00, Status = SaleStatus.Pending, Seller = s5};
            SalesRecord r5 = new SalesRecord {Id = 5, Date = new DateTime(2018,04,11), Amount = 20000.00, Status = SaleStatus.Billed, Seller = s4};
            SalesRecord r6 = new SalesRecord {Id = 6, Date = new DateTime(2019,06,18), Amount = 11000.00, Status = SaleStatus.Pending, Seller = s6};
            SalesRecord r7 = new SalesRecord {Id = 7, Date = new DateTime(2019,09,5), Amount = 15030.00, Status = SaleStatus.Canceled, Seller = s1 };
            SalesRecord r8 = new SalesRecord {Id = 8, Date = new DateTime(2019,05,07), Amount = 10000.00, Status = SaleStatus.Billed, Seller = s2};
            SalesRecord r9 = new SalesRecord {Id = 9, Date = new DateTime(2019,08,05), Amount = 19000.00, Status = SaleStatus.Billed, Seller = s4};
            SalesRecord r10 = new SalesRecord {Id = 10, Date = new DateTime(2019,09,11), Amount = 25000.00, Status = SaleStatus.Canceled, Seller = s5};
            SalesRecord r11 = new SalesRecord {Id = 11, Date = new DateTime(2017,11,05), Amount = 35000.00, Status = SaleStatus.Billed, Seller = s2};
            SalesRecord r12 = new SalesRecord {Id = 12, Date = new DateTime(2019,08,10), Amount = 5000.00, Status = SaleStatus.Pending, Seller = s1 };

            _context.Department.AddRange(d1,d2,d3,d4,d5);
            _context.Sellers.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12);

            _context.SaveChanges();

        }
    }
}
