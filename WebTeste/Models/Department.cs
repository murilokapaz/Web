using System;
using System.Collections.Generic;
using System.Linq;


namespace WebTeste.Models.ViewModels
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Department()
        {
    
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)//retorna total de vendas por departamento
        {
            return Sellers.Sum(seller=> seller.TotalSales(initial, final));
        }

    }


    


 
}
