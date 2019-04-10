using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryGit.Models
{
    public class Company
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}