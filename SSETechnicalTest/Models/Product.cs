using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSETechnicalTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
