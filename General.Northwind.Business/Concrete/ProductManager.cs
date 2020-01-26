using General.Northwind.Business.Abstract;
using General.Northwind.DataAccess.Abstract;
using General.Northwind.DataAccess.Concrete.EntityFramework;
using General.Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace General.Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public List<Product> GetAll()
        {
            //Üst katman altkatmanı newlememeli.O yüzden const.ile productDalı aldık.
            // EfProductDAL productDal = new EfProductDAL();
            // return productDal.GetList();
            return _productDAL.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

       
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
