using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto employeeDto);
        void UpdateEmployee(UpdateEmployeeDto employeeDto);
        void DeleteEmployee(int id);
        Task<ResultEmployeeDto> GetEmployee(int id);
    }
}
