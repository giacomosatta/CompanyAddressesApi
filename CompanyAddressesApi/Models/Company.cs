using System.ComponentModel.DataAnnotations;

namespace CompanyAddressesApi.Models;

public class Company
{
    [Required(ErrorMessage = "Company Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Registration Number is required")]
    public string RegistrationNumber { get; set; }

    [Required(ErrorMessage = "Addresses are required")]
    [MinLength(1, ErrorMessage = "Addresses cannot be empty")]
    public List<Address> Addresses { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, RegistrationNumber: {RegistrationNumber},\nAddresses:{string.Join(";\n ", Addresses)}";
    }
}