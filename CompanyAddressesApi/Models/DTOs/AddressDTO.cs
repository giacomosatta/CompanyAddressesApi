
namespace CompanyAddressesApi.Models.DTOs;

public class AddressDTO
{
    public string FullAddress { get; set; }



    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        AddressDTO other = (AddressDTO)obj;

        return FullAddress == other.FullAddress;

    }
}

 