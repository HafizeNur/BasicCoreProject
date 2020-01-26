using General.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
