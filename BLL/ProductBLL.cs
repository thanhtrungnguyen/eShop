using BLL.Interface;
using DAL.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL : IProductBLL
    {
        private readonly IProductDAL _prouductDal;
        public ProductBLL(IProductDAL productDal)
        {
            _prouductDal = productDal;
        }
        public int CreateProduct(Product product)
        {
            return _prouductDal.CreateProduct(product);
        }

        public int DeleteProduct(int id)
        {
            return _prouductDal.DeleteProduct(id);
        }

        public Product GetProduct(int id)
        {
            return _prouductDal.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _prouductDal.GetProducts();
        }

        public int UpdateProduct(Product product)
        {
            return _prouductDal.UpdateProduct(product);
        }
    }
}
