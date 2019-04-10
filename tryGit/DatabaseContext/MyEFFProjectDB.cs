using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using tryGit.Models;

namespace tryGit.DatabaseContext
{
    //eff db context inherit this class
    public class MyEFFProjectDB: DbContext
    {
        public DbSet<Product> Products { get; set; } 
    }
}