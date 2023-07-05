using Ecommerce.Core.DataAccess.EntityFramework;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Concred.EntityFramework
{
    public class EFCategoryDal: EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
