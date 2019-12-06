using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebTeste.Models.ViewModels;


namespace WebTeste.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is Required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size shold be between {2} and {1}")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name= "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base Salary")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2} ")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();


        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

 
       public Seller()
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
