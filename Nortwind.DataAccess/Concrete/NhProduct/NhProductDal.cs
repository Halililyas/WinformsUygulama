using Nortwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.NhProduct
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

      

        public Product get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
           {
               new Product
               {
                    ProductId = 1 ,
                    CategoryId =1 ,
                    ProductName = "laptop" ,
                    QuantityPerUnit = "1 in a box " ,
                    UnitPrice = 3000 }
              };
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
