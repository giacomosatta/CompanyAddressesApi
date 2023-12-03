
namespace CompanyAddressesApi.Models.DTOs;

public class AddressDTO
{
    private string fullAddress { get; set; }

    public string FullAddress
    {

        get { return fullAddress; }
        set { fullAddress = value; }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        AddressDTO other = (AddressDTO)obj;

        return FullAddress == other.FullAddress;

    }
}

