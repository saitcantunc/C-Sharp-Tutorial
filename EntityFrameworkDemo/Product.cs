using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; } //Primary key
        public int CategoryId { get; set; } //Foreign key >> Başka tablolarda ilişkilendirilen id
        public String ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
