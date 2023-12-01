using CompanyAddressesApi.Models;
using CompanyAddressesApi.Models.DTOs;

namespace CompanyAddressesApi.Service.Interface;
public interface IFileWriterService
{
    Task WriteAddress(CompanyDTO company);
}