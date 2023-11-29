using System.Text;
using CompanyAddressesApi.Models;
using CompanyAddressesApi.Service.Interface;

namespace CompanyAddressesApi.Service;

public class FileWriterService : IFileWriterService
{
    private readonly string filePath = "company-addresses-{0}.txt";
    public async Task WriteAddress(Company company)
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"{company.Name} ({company.RegistrationNumber}):");

        foreach (var address in company.Addresses)
            stringBuilder.AppendLine($"\tAddress: {address.Street}, {address.City} {address.PostalCode}, {address.Country}");


        await File.AppendAllTextAsync(String.Format(filePath, Guid.NewGuid()), stringBuilder.ToString());
    }
}
