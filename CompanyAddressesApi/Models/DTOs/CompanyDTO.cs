namespace CompanyAddressesApi.Models.DTOs;

public class CompanyDTO
{
    public string Name { get; set; }
    public string RegistrationNumber { get; set; }
    public List<AddressDTO> Addresses { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, RegistrationNumber: {RegistrationNumber},\nAddresses:{string.Join(";\n ", Addresses)}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        CompanyDTO other = (CompanyDTO)obj;

        return Name == other.Name
    && RegistrationNumber == other.RegistrationNumber
    && Addresses.SequenceEqual(other.Addresses);

    }

}