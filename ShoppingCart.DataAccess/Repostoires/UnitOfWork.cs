using ShoppingCart.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repostoires
{
    public class UnitOfWork : IUnitOfWork
    {
        
        private ApplicationDBContext _dbcontex;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDBContext contex)
        {
            _dbcontex=contex;
            Category = new CategoryRepository(contex);
            Product= new ProductRepository(contex);
        }

        public void Save()
        {
            _dbcontex.SaveChanges();
           
        }
    }
}
