using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Products
{
    public interface IProductsAppService : IApplicationService
    {
        public void CreateProduct(ProductDto input);
        public void UpdateProduct(int id, ProductDto input);
        public void DeleteProduct(int id);
        public Product GetProduct(int id);
        public IEnumerable<Product> GetAll();
    }
}