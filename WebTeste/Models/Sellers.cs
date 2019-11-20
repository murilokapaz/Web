using System;
using System.Collections.Generic;
using System.Linq;
using WebTeste.Models.ViewModels;


namespace WebTeste.Models
{
    public class Sellers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();


        public Sellers(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Sellers()
        {
            
        }

        public void AddSales(SalesRecord sr)
        {
            SalesRecord.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            SalesRecord.Remove(sr);
        }
        
        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecord.Where(s => s.Date >= initial && s.Date <= final).Sum(s=> s.Amount);
        }
    }
}
