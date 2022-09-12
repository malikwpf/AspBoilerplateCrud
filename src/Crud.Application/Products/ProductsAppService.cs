using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Products
{
    public class ProductsAppService: IProductsAppService
    {
        private readonly IRepository<Product> _productRepository;
        public ProductsAppService(IRepository<Product> personRepository)
        {
            _productRepository = personRepository;
        }

        public void CreateProduct(ProductDto input)
        {
          

           var  product = new Product { Name = input.Name, Quantity = input.Quantity };
            _productRepository.Insert(product);
        }

        public void DeleteProduct(int id)
        {
           var product= GetProduct(id);

            _productRepository.Delete(product);

        }

        public IEnumerable<Product> GetAll()
        {
           return _productRepository.GetAllList();
        }

        public Product GetProduct(int id)
        {
            if (id == null)
            {
                throw new UserFriendlyException("There is no such product");
            }


            var product = _productRepository.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new UserFriendlyException("There is no such product");
            }

            return product;
        }

        public void UpdateProduct(int id, ProductDto input)
        {
            var product = GetProduct(id);

            product.Name=input.Name;
            product.Quantity = input.Quantity;

            _productRepository.Update(product);

        }
    }
}
