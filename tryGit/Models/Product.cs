using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tryGit.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        public string Code { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }
        [Required]
        public int ShopId { get; set; }

        public Company Company { get; set; }
        public Shop Shop { get; set; }
    }
}