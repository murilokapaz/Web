using System;
using WebTeste.Models.Enums;

namespace WebTeste.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Sellers Seller { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Sellers sellers)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = sellers;
        }

        public SalesRecord()
        {

        }
    }
}
