using General.Core.DataAccess;
using General.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Northwind.DataAccess.Abstract
{
    public interface ICategoryDAL : IEntityRepository<Category>
    {
        //Custom Operations
    }
  
}
