using System.Collections.Generic;
using unitofwork.Models;

namespace unitofwork.UOW
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(long id);
        IEnumerable<Product> GetProducts();
        bool DeleteProduct(long productId);
    }
}