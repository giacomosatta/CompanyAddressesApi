using System.ComponentModel.DataAnnotations;

namespace CompanyAddressesApi.Models;

public class Address
{
    [Required(ErrorMessage = "Street is required")]
    public string Street { get; set; }

    [Required(ErrorMessage = "City is required")]
    public string City { get; set; }

    [Required(ErrorMessage = "PostalCode is required")]
    public string PostalCode { get; set; }

    [Required(ErrorMessage = "Country  is required")]
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Street: {Street}, City: {City}, PostalCode: {PostalCode}, Country: {Country}";
    }
}