using Mango.Services.ProductAPI.DbContexts.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        /*
         * The Task class represents a single operation that does not return a value and 
         * that usually executes asynchronously. 
         *
         * IEnumerable is the base interface for all non-generic collections that can be enumerated.
         * IEnumerator provides the ability to iterate through the collection 
         * by exposing a Current property and MoveNext and Reset methods.
         */
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int id);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int id);
    }
}
