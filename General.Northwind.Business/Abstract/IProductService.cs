﻿using General.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
