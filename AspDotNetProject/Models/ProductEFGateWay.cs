using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspDotNetProject.Models
{
    public class ProductEFGateWay
    {
        ProductDBEntities db = new ProductDBEntities();
        public IQueryable<Product> GetProducts()
        {
            return from pro in db.Products select pro;
        }
        public Product GetProduct(int id)
        {
            Product pro = db.Products.FirstOrDefault(p => p.ProductId == id);
            return pro;
        }
        public void InsertProduct(Product obj)
        {
            db.Products.Add(obj);
            db.SaveChanges();
        }
        public int UpdateProduct(Product upObj)
        {
            int count = 0;
            Product obj = GetProduct(upObj.ProductId);
            obj.ProductName = upObj.ProductName;
            obj.EntryDate = upObj.EntryDate;
            
            obj.UnitPrice = upObj.UnitPrice;
            obj.ImageName = upObj.ImageName;
            obj.ImageFile = upObj.ImageFile;
            obj.CategoryId = upObj.CategoryId;
            count = db.SaveChanges();
            return count;
        }
        public int DeleteProduct(int id)
        {
            int count = 0;
            Product deleteProduct = GetProduct(id);
            db.Products.Remove(deleteProduct);
            count = db.SaveChanges();
            return count;

        }
    }
}