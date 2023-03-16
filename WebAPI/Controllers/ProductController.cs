using BLL.Interface;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductBLL _productBll;
        public ProductController(IProductBLL productBll)
        {
            _productBll = productBll;
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            List<Product> products = _productBll.GetProducts();
            return products;
        }

        [HttpGet("{id:int}")]
        public Product GetProducts(int id)
        {
            Product product = _productBll.GetProduct(id);
            return product;
        }

        [HttpPost]
        public int CreateProduct(string name, float price, string description)
        {
            Product product = new Product(name, price, description);
            int result = _productBll.CreateProduct(product);
            return result;
        }

        [HttpPut("{id:int}")]
        public int UpdateProduct(int id, string name, float price, string description)
        {
            Product product = new Product(id, name, price, description);
            int result = _productBll.UpdateProduct(product);
            return result;
        }

        [HttpDelete("{id:int}")]
        public int DeleteProduct(int id)
        {
            int result = _productBll.DeleteProduct(id);
            return result;
        }
    }
}
