using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tryGit.DatabaseContext;
using tryGit.Models;

namespace tryGit.Repository
{
    public class ProductRepository
    {
        MyEFFProjectDB db = new MyEFFProjectDB();

        public bool SaveProduct(Product productObj)
        {
            db.Products.Add(productObj);
            var Save = db.SaveChanges();
            if (Save>0)
            {
                return true;
            }
            return false;
        }
    }
}