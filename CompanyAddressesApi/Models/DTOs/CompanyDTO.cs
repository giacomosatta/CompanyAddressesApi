namespace CompanyAddressesApi.Models.DTOs;

public class CompanyDTO
{
    private string name { get; set; }
    private string registrationNumber { get; set; }
    private List<AddressDTO> addresses { get; set; }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string RegistrationNumber
    {
        get { return registrationNumber; }
        set { registrationNumber = value; }
    }

    public List<AddressDTO> Addresses
    {
        get { return addresses; }
        set { addresses = value; }
    }

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