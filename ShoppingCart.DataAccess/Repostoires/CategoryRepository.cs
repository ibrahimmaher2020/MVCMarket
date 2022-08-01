using ShoppingCart.DataAccess.Data;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repostoires
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDBContext _dbContext;
        public CategoryRepository(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public void Update(Category category)
        {
            var categorydb = _dbContext.Categories.FirstOrDefault(f=>f.Id==category.Id);
            if (categorydb != null)
            {
                categorydb.Name=category.Name;
                categorydb.DisplayOrder=category.DisplayOrder;
                
                
            }
        }
    }
}
