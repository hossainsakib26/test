using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tryGit.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Code { get; set; }
        public int CompanyId { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }
        public int ShopId { get; set; }
    }
}