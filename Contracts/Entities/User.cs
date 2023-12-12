using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public class User
    {
       [Key]
        public int id { get; set; }

        public string login { get; set; }
        public string password { get; set; }

        public string numbers { get; set; }
    }
}
