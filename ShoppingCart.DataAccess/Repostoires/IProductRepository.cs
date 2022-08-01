using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Models;

namespace ShoppingCart.DataAccess.Repostoires
{
    public interface IProductRepository:IRepository<Product>
    {
        void update(Product product);
    }
}
