using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tryGit.Models;
using tryGit.Repository;

namespace tryGit.BLL
{
    public class ProductManager
    {
        ProductRepository _databaseManager = new ProductRepository();

        public bool SaveProduct(Product productObj)
        {
            var isSave = _databaseManager.SaveProduct(productObj);
            return isSave;
        }
    }
}