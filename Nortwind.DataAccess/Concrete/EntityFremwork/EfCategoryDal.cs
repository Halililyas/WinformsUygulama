using Nortwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using Nortwind.Entities.Concrete.EntityFremwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAccess.Concrete.EntityFremwork
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NortwindContext>,ICategoryDal
    {
    }
}
