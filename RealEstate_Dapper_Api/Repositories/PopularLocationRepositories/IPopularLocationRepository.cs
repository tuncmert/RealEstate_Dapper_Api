using RealEstate_Dapper_Api.Dtos.PopularLocaitonDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
    }
}
