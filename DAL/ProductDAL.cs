using DAL.Interface;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDAL : IProductDAL
    {
        private readonly IDataProvider _provider;
        public ProductDAL(IDataProvider provider)
        {
            _provider = provider;
        }
        public int CreateProduct(Product product)
        {
            string query = string.Format(@"INSERT INTO Product (name, price, description) VALUES ('{0}',{1},'{2}');", product.Name, product.Price, product.Description);
            return _provider.ExecuteNonQuery(query);
        }

        public int DeleteProduct(int id)
        {
            string query = string.Format(@"DELETE FROM Product WHERE id = {0};", id);
            return _provider.ExecuteNonQuery(query);
        }

        public Product? GetProduct(int key)
        {
            string query = "SELECT * FROM Product WHERE id = " + key;
            DataTable dataTable = _provider.ExecuteQuery(query);
            Product? product = null;
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                int id = Int32.Parse(dataRow["id"].ToString());
                string name = dataRow["name"].ToString();
                float price = float.Parse(dataRow["price"].ToString());
                string descrpition = dataRow["description"].ToString();
                product = new Product(id, name, price, descrpition);
            }
            return product;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            string query = "SELECT * FROM Product";
            DataTable dataTable = _provider.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                int id = Int32.Parse(row["id"].ToString());
                string name = row["name"].ToString();
                float price = float.Parse(row["price"].ToString());
                string descrpition = row["description"].ToString();

                Product product = new Product(id, name, price, descrpition);

                products.Add(product);
            }
            return products;
        }

        public int UpdateProduct(Product product)
        {
            string query = string.Format(@"UPDATE Product SET name = '{0}', price = {1}, description = '{2}' WHERE id = {3};", product.Name, product.Price, product.Description, product.Id);
            return _provider.ExecuteNonQuery(query);
        }
    }
}
