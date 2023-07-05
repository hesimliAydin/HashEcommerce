using Ecommerce.Core.DataAccess;
using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {

    }
}
