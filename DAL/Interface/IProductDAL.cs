using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IProductDAL
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        int CreateProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
    }
}
