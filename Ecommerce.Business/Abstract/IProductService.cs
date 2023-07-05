﻿using Ecommerce.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
    }
}
