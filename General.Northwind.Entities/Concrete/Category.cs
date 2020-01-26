using General.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Northwind.Entities
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
