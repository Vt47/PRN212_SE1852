using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepositories iproductRepositories;
        public ProductService()
        {
            iproductRepositories = new ProductRepositories();
        }

        public bool DeleteProduct(int id)
        {
            return iproductRepositories.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            return iproductRepositories.GetProducts();
        }

        public void InitializeDataset()
        {
            iproductRepositories.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return iproductRepositories.SaveProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return iproductRepositories.UpdateProduct(p);
        }
    }
}
