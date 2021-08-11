using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ProductDao
    {
        WebbanhangDbContext db = null;

        public ProductDao()
        {
            db = new WebbanhangDbContext();
        }

        public List<Product> ListNewProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.CreateBy).Take(top).ToList();
        }
        public List<Product> ListbyCategoryId(long categoryID, ref int totalRecord ,int pageIndex=1, int pageSize=2)
        {
            totalRecord = db.Products.Where(x => x.CategoryID == categoryID).Count();
            var model = db.Products.Where(x => x.CategoryID == categoryID).OrderByDescending(x=>x.CreateDate).Skip((pageIndex - 1)* pageSize).Take(pageSize).ToList();
            return model;
        }
        public List<Product> ListFeatureProduct(int top)
        {
            return db.Products.Where(x => x.TopHot != null && x.TopHot > DateTime.Now).OrderByDescending(x => x.CreateBy).Take(top).ToList();
        }
        public List<Product> ListRelatedProducts(long productId)
        {
            var product = db.Products.Find(productId);
            return db.Products.Where(x => x.ID != productId && x.CategoryID == product.CategoryID).ToList() ;
        }
        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }

    }
}
