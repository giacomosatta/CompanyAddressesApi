using CompanyAddressesApi.Models;

namespace CompanyAddressesApi.Service.Interface;
public interface IFileWriterService
{
    Task WriteAddress(Company company);
}