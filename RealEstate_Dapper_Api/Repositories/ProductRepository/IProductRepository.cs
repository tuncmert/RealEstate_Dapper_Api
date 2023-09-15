
using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        //void CreateCategory(CreateCategoryDto categoryDto);
        //void UpdateCategory(UpdateCategoryDto categoryDto);
        //void DeleteCategory(int id);
        //Task<ResultCategoryDto> GetCategory(int id);
    }
}
