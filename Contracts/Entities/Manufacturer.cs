using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public class Manufacturer
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string adress { get; set; }
    }
}
