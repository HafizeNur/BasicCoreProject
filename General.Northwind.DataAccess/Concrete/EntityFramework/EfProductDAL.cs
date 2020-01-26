using General.Core.DataAccess.EntityFramework;
using General.Northwind.DataAccess.Abstract;
using General.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDAL : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDAL
    {
    }
}
