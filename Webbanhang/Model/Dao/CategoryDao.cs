using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CategoryDao
    {
        WebbanhangDbContext db = null;
        public CategoryDao()
        {
            db = new WebbanhangDbContext();
        }
        public List<Catrgory> ListAll()
        {
            return db.Catrgories.Where(x => x.Status == true).ToList();
        }
        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
    }
}
