using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public Manufacturer manufacturer { get; set; }

    }
}
