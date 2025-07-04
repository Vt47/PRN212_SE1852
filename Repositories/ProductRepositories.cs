using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepositories: IProductRepositories
    {
        ProductDAO productDAO = new ProductDAO();

        public bool DeleteProduct(int id)
        {
            return productDAO.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            return productDAO.GetProducts();
        }

        public void InitializeDataset()
        {
            productDAO.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productDAO.SaveProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return productDAO.UpdateProduct(p);
        }
    }
}
