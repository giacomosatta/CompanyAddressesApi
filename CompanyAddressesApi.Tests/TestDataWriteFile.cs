using System.Text.Json;
using CompanyAddressesApi.Models;
using CompanyAddressesApi.Models.DTOs;

public class TestDataWriteFile
{

    private static readonly string companyJson = File.ReadAllText("Resources/CompanyInitializer.json");
    public static Company BuildCompany()
    {
        var options = new JsonSerializerOptions { IncludeFields = true, PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<Company>(companyJson, options);
    }

    public static CompanyDTO BuildCompanyDTO()
    {
        var companyDTO = new CompanyDTO
        {
            Name = "Initech",
            RegistrationNumber = "123456789",
            Addresses =
        [
            new AddressDTO
            {
                FullAddress = $"Street: 1234 Elm Street, City: Springfield, PostalCode: 12345, Country: USA"
            },
            new AddressDTO
            {
                FullAddress = $"Street: 9876 Oak Street, City: Shelbyville, PostalCode: 67890, Country: USA"
            },
        ]
        };

        return companyDTO;
    }
}