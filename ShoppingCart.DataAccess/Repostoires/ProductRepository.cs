using ShoppingCart.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repostoires
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _dbContext;
        public ProductRepository(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
        }

        public void update(Product product)
        {
            var productdb = _dbContext.Products.FirstOrDefault(p => p.Id == product.Id);            
            if (productdb != null)
            {
                productdb.Name=product.Name;
                productdb.Description=product.Description;
                productdb.Price=product.Price;
                if (productdb.ImgUrl!=null)
                {
                    productdb.ImgUrl = product.ImgUrl;
                }
            }
        }
    }
}
