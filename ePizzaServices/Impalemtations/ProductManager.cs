using ePizza.En.Dtos.Products;
using ePizza.Entities.Dtos.Products;
using ePizza.Repositories.Interfaces;
using ePizza.Shared.Utilities.Abstract;
using ePizzaServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaServices.Impalemtations
{
    public class ProductManager : IProductSerice
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IDataResult<ProductDto>> AddAsync(ProductAddDto productAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ProductDto>> DeleteAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ProductListDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ProductDto>> GetAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ProductDto>> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
