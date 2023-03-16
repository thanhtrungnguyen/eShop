using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IProductBLL
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        int CreateProduct(Product product);
        int UpdateProduct(Product product);
        int DeleteProduct(int id);
    }
}
