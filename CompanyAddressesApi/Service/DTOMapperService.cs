using CompanyAddressesApi.Models;
using CompanyAddressesApi.Models.DTOs;

namespace CompanyAddressesApi.Service;
public static class DTOMapperService
{
    public static CompanyDTO CompanyMapToDTO(Company company)
    {
        return new CompanyDTO
        {
            Name = company.Name,
            RegistrationNumber = company.RegistrationNumber,
            Addresses = company.Addresses.Select(AddressMapToDTO).ToList()
        };
    }

    public static AddressDTO AddressMapToDTO(Address address)
    {
        return new AddressDTO
        {
            FullAddress = $"Street: {address.Street}, City: {address.City}, PostalCode: {address.PostalCode}, Country: {address.Country}"
        };
    }
}