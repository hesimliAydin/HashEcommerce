using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Concred
{
    public class ProductService : IProductService
    {

        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetList(p=>p.CategoryId == id || id==0);
        }
    }
}
