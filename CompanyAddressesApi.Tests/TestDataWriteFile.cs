using System.Text.Json;
using CompanyAddressesApi.Models;

public class TestDataWriteFile
{

    private static readonly string companyJson = File.ReadAllText("Resources/CompanyInitializer.json");
    public static Company BuildCompany()
    {
        var options = new JsonSerializerOptions { IncludeFields = true, PropertyNameCaseInsensitive = true };
        return JsonSerializer.Deserialize<Company>(companyJson,options);
    }
}