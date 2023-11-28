using FluentValidation;
using Nortwind.Business.Abstract;
using Nortwind.Business.Utlitis;
using Nortwind.Business.ValidationRules.FluentValidation;
using Nortwind.DataAccess.Abstract;
using Nortwind.DataAccess.Concrete;
using Nortwind.DataAccess.Concrete.EntityFremwork;
using Nortwind.DataAccess.Concrete.NhProduct;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.Business.Concrete.EntityFremwork
{
    public class ProductManager:IProductServer
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValiditar(), product);
            _productDal.Add(product);
        }

       

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //Business code
            return _productDal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetProductByName(string productname)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productname.ToLower()));
        }

        public void Update(Product product)
        {
            //ValidationTool.Validate(new ProductValiditar(), product);
            _productDal.Update(product);
        }
    }
}
