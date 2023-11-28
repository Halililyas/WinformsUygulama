using Nortwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using Nortwind.Entities.Concrete.EntityFremwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFremwork
{
    public class EfProductDal: EfEntityRepositoryBase<Product,NortwindContext>,IProductDal
    {
       
        
       
    }
}
