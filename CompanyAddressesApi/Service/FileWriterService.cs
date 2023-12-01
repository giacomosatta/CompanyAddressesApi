using System.Text;
using CompanyAddressesApi.Models.DTOs;
using CompanyAddressesApi.Service.Interface;

namespace CompanyAddressesApi.Service;

public class FileWriterService : IFileWriterService
{
    private readonly string filePath = "company-addresses-{0}.txt";
    public async Task WriteAddress(CompanyDTO company)
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"{company.Name} ({company.RegistrationNumber}):");

        foreach (var address in company.Addresses)
            stringBuilder.AppendLine($"\tAddress: {address.FullAddress}");

        await File.AppendAllTextAsync(String.Format(filePath, Guid.NewGuid()), stringBuilder.ToString());
    }
}
