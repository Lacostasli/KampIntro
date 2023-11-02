using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product // ürünün özelliklerini sıraladık
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //ürün birim fiyatı

        public int UnitInStock { get; set; } //ürünün stok adedi


        

    }
}
